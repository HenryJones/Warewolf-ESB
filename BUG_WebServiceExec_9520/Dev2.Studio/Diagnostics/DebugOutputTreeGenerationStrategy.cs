﻿using Dev2.Diagnostics;
using Dev2.Enums;
using Dev2.Studio.Core.Interfaces;
using Dev2.Studio.ViewModels.Diagnostics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Dev2.Studio.Diagnostics
{
    public class DebugOutputTreeGenerationStrategy
    {
        #region Class Members

        readonly DebugOutputFilterStrategy _debugOutputFilterStrategy;
        readonly IEnvironmentRepository _environmentRepository;

        #endregion Class Members

        #region Constructor

        public DebugOutputTreeGenerationStrategy(IEnvironmentRepository environmentRepository = null)
        {
            _environmentRepository = environmentRepository;
            _debugOutputFilterStrategy = new DebugOutputFilterStrategy();
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Places the content in tree.
        /// </summary>
        /// <param name="content">The content.</param>
        public DebugTreeViewItemViewModel PlaceContentInTree(ObservableCollection<DebugTreeViewItemViewModel> rootItems, List<IDebugState> existingContent,
            IDebugState newContent, string filterText, bool addedAsParent, int depthLimit)
        {
            int depthCount = 0;
            return PlaceContentInTree(rootItems, existingContent, newContent, filterText, addedAsParent, depthLimit, ref depthCount);
        }

        //
        //Juries - This is a dirty hack, naughty naughty.
        //Hijacked current functionality to enable erros to be added to an item after its already been added to the tree
        //
        public void AppendErrorToTreeParent(ObservableCollection<DebugTreeViewItemViewModel> rootItems, List<IDebugState> existingContent,
            IDebugState debugState)
        {
            int operationDepth = 0;
            var parentItem = FindParent(rootItems, debugState, ref operationDepth);
            if (parentItem is DebugStateTreeViewItemViewModel)
            {
                var debugStateParent = (DebugStateTreeViewItemViewModel)parentItem;
                debugStateParent.AppendError(debugState.ErrorMessage);
            }
        }
        #endregion Methods

        #region Private Methods

        private DebugTreeViewItemViewModel PlaceContentInTree(IList<DebugTreeViewItemViewModel> rootItems, List<IDebugState> existingContent,
            IDebugState newContent, string filterText, bool addedAsParent, int depthLimit, ref int operationDepth)
        {
            //
            // Check if content should be placed in the tree
            //
            if (!string.IsNullOrWhiteSpace(filterText) && !_debugOutputFilterStrategy.Filter(newContent, filterText)) return null;

            DebugTreeViewItemViewModel newItem = null;

            if (newContent != null && newContent.StateType != StateType.Message)
            {
                //
                // Find the node which to add the item to
                //
                DebugTreeViewItemViewModel parentItem = null;
                if (!addedAsParent)
                {
                    parentItem = FindParent(rootItems, newContent, ref operationDepth);
                }

                if (parentItem == null)
                {
                    parentItem = AddMissingParent(rootItems, existingContent, newContent, depthLimit, ref operationDepth);
                }

                if (depthLimit <= 0 || operationDepth < depthLimit)
                {
                    if (parentItem == null)
                    {
                        //
                        // Add as root node
                        //
                        newItem = new DebugStateTreeViewItemViewModel(_environmentRepository, newContent, null, true, false, addedAsParent);
                        AddOrInsertItem(rootItems, existingContent, newContent, newItem, addedAsParent);
                        return newItem;
                    }
                    
                    newItem = new DebugStateTreeViewItemViewModel(_environmentRepository, newContent, parentItem, isExpanded: true, isSelected: false, addedAsParent: addedAsParent);
                    AddOrInsertItem(parentItem.Children, existingContent, newContent, newItem, addedAsParent);
                    return newItem;
                }
            }
            else if (newContent != null && newContent.StateType == StateType.Message)
            {
                newItem = new DebugStringTreeViewItemViewModel(newContent.Message, null, true, false, addedAsParent);
                AddOrInsertItem(rootItems, existingContent, newContent, newItem, addedAsParent);
                return newItem;
            }
            //newItem = new DebugProcessingIconViewModel(true);

            //AddOrInsertItem(rootItems, existingContent, newContent, newItem, addedAsParent);
            //return newItem;
            return null;
        }

        void SetError(object content, DebugTreeViewItemViewModel treeviewItem, bool addedAsParent)
        {
            if ((content is IDebugState) && !addedAsParent)
            {
                if (((IDebugState)content).HasError)
                {
                    treeviewItem.HasError = true;
                }
            }
            else treeviewItem.VerifyErrorState();

        }

        /// <summary>
        /// Adds the or insert item.
        /// </summary>
        /// <param name="destinationCollection">The destination collection.</param>
        /// <param name="content">The content to insert.</param>
        /// <param name="treeviewItem">The treeview item.</param>
        /// <param name="addedAsParent">if set to <c>true</c> [added as parent].</param>
        /// <exception cref="System.Exception">Content not found in original list.</exception>
        private void AddOrInsertItem(IList<DebugTreeViewItemViewModel> destinationCollection, List<IDebugState> existingContent,
            IDebugState content, DebugTreeViewItemViewModel treeviewItem, bool addedAsParent)
        {
            if (!addedAsParent)
            {
                destinationCollection.Add(treeviewItem);
            }
            else
            {
                int originalIndex = existingContent.IndexOf(content);

                if (originalIndex < 0)
                {
                    throw new Exception("Content not found in original list.");
                }

                bool insterted = false;
                for (int i = 0; i < destinationCollection.Count; i++)
                {
                    var item = destinationCollection[i] as DebugStateTreeViewItemViewModel;
                    if (item == null) break;

                    int itemIndex = existingContent.IndexOf(item.Content);
                    if (itemIndex > originalIndex)
                    {
                        insterted = true;
                        destinationCollection.Insert(i, treeviewItem);
                        break;
                    }
                }

                if (!insterted)
                {
                    destinationCollection.Add(treeviewItem);
                }
            }
            SetError(content, treeviewItem, addedAsParent);
        }

        /// <summary>
        /// Finds the parent.
        /// </summary>
        /// <param name="parentID">The parent ID.</param>
        private DebugTreeViewItemViewModel FindParent(IEnumerable<DebugTreeViewItemViewModel> rootItems,
            IDebugState debugState, ref int operationDepth)
        {
            if (string.IsNullOrWhiteSpace(debugState.ParentID) || debugState.ID == debugState.ParentID)
            {
                return null;
            }

            foreach (DebugTreeViewItemViewModel item in rootItems)
            {
                DebugTreeViewItemViewModel match = item.FindSelfOrChild(n =>
                {
                    DebugStateTreeViewItemViewModel debugStateTreeViewItemViewModel = n as DebugStateTreeViewItemViewModel;
                    if (debugStateTreeViewItemViewModel == null)
                    {
                        return false;
                    }

                    return debugStateTreeViewItemViewModel.Content.ID == debugState.ParentID;
                });

                if (match != null)
                {
                    operationDepth = match.GetDepth() + 1;
                    return match;
                }
            }

            return null;
        }

        /// <summary>
        /// Finds the parent.
        /// </summary>
        /// <param name="parentID">The parent ID.</param>
        private DebugTreeViewItemViewModel AddMissingParent(IList<DebugTreeViewItemViewModel> rootItems, List<IDebugState> existingContent,
            IDebugState debugState, int depthLimit, ref int operationDepth)
        {
            if (string.IsNullOrWhiteSpace(debugState.ParentID) || debugState.ID == debugState.ParentID)
            {
                return null;
            }

            IDebugState parent = existingContent.FirstOrDefault(o => o is IDebugState && o != debugState && ((IDebugState)o).ID == debugState.ParentID) as IDebugState;
            if (parent == null)
            {
                return null;
            }

            operationDepth++;
            return PlaceContentInTree(rootItems, existingContent, parent, "", true, depthLimit, ref operationDepth);
        }

        #endregion Private Methods
    }
}

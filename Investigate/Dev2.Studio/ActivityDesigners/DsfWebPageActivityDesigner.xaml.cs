﻿using System;
using System.Windows;
using System.Activities.Presentation.Model;
using Caliburn.Micro;
using Dev2.Composition;
using Dev2.Studio.Core.Interfaces.DataList;
using Dev2.Studio.Core.Messages;

namespace Unlimited.Applications.BusinessDesignStudio.Activities {
    public partial class DsfWebPageActivityDesigner : IDisposable, IHandle<DataListItemSelectedMessage>
    {
        public DsfWebPageActivityDesigner()
        {
            InitializeComponent(); EventAggregator = ImportService.GetExportValue<IEventAggregator>();
            EventAggregator.Subscribe(this);
        }

        protected IEventAggregator EventAggregator { get; set; }

        protected override void OnModelItemChanged(object newItem) {
            base.OnModelItemChanged(newItem);
           

            ModelItem item = newItem as ModelItem;


            ModelItem parent = item.Parent;

            while (parent != null)
            {
                if (parent.Properties["Argument"] != null)
                {
                    break;
                }

                parent = parent.Parent;
            }
        }

        private void Highlight(IDataListItemModel dataListItemViewModel) {
            bool setVisible = false;
            border.Visibility = Visibility.Hidden;
            if (string.IsNullOrEmpty(dataListItemViewModel.Name)) {
                setVisible = false;
            }
            else {
                //setVisible = DsfActivityDataListComparer.ContainsDataListItem(ModelItem, dataListItemViewModel);
            }
            if (setVisible) {
                border.Visibility = Visibility.Visible;
            }
        }

        public void Handle(DataListItemSelectedMessage message)
        {
            Highlight(message.DataListItemModel);
        }

        public void Dispose()
        {
            EventAggregator.Unsubscribe(this);
        }
    }
}

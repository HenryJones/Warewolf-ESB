﻿using Dev2.Common.ExtMethods;
using Dev2.Studio.AppResources.Comparers;
using Dev2.Studio.Core;
using Dev2.Studio.Core.AppResources.Enums;
using Dev2.Studio.Core.AppResources.ExtensionMethods;
using Dev2.Studio.Core.Helpers;
using Dev2.Studio.Core.Interfaces;
using Dev2.Studio.ViewModels.Workflow;
using Dev2.Studio.ViewModels.WorkSurface;
using System;

namespace Dev2.Studio.Factory
{
    public static class WorkSurfaceContextFactory
    {

        public static WorkSurfaceContextViewModel CreateResourceViewModel(IContextualResourceModel resourceModel, bool createDesigner = true)
        {
            var key = WorkSurfaceKeyFactory.CreateKey(resourceModel);

            //TODO Juries move to factory
            var workSurfaceVM = new WorkflowDesignerViewModel(resourceModel, createDesigner);

            var contextVM = new WorkSurfaceContextViewModel(key, workSurfaceVM)
                {
                    DataListViewModel = DataListViewModelFactory.CreateDataListViewModel(resourceModel)
                };

            return contextVM;
        }

        public static WorkSurfaceContextViewModel CreateDeployViewModel(object input)
        {
            var vm = DeployViewModelFactory.GetDeployViewModel(input);
            var context = CreateUniqueWorkSurfaceContextViewModel(vm, WorkSurfaceContext.DeployResources);
            return context;
        }

        /// <summary>
        /// Creates the work surface context view model, only use for surfaces that are unique per context.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="vm">The vm.</param>
        /// <param name="workSurfaceContext">The work surface context.</param>
        /// <returns></returns>
        /// <author>Jurie.smit</author>
        /// <date>3/6/2013</date>
        public static WorkSurfaceContextViewModel CreateUniqueWorkSurfaceContextViewModel<T>
            (T vm, WorkSurfaceContext workSurfaceContext)
            where T : IWorkSurfaceViewModel
        {
            var key = WorkSurfaceKeyFactory.CreateKey(workSurfaceContext);
            return CreateWorkSurfaceContextViewModel(vm, workSurfaceContext, key);
        }

        /// <summary>
        /// Creates the work surface context view model, only use for surfaces that are unique per server.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="vm">The vm.</param>
        /// <param name="workSurfaceContext">The work surface context.</param>
        /// <param name="serverID">The server ID.</param>
        /// <returns></returns>
        /// <date>3/6/2013</date>
        /// <author>
        /// Jurie.smit
        /// </author>
        public static WorkSurfaceContextViewModel CreateWorkSurfaceContextViewModelForServer<T>
            (T vm, WorkSurfaceContext workSurfaceContext, Guid serverID)
            where T : IWorkSurfaceViewModel
        {
            var key = WorkSurfaceKeyFactory.CreateKey(workSurfaceContext, serverID);
            return CreateWorkSurfaceContextViewModel(vm, workSurfaceContext, key);
        }

        private static WorkSurfaceContextViewModel CreateWorkSurfaceContextViewModel<T>(T vm,
                                                                                        WorkSurfaceContext workSurfaceContext,
                                                                                        WorkSurfaceKey key)
            where T : IWorkSurfaceViewModel
        {
            var context = new WorkSurfaceContextViewModel(key, vm);
            vm.DisplayName = workSurfaceContext.GetDescription();
            vm.IconPath = workSurfaceContext.GetIconLocation();
            vm.WorkSurfaceContext = workSurfaceContext;
            return context;
        }

        public static WorkSurfaceContextViewModel Create<T>(WorkSurfaceContext workSurfaceContext, Tuple<string, object>[] initParms)
            where T : IWorkSurfaceViewModel
        {
            var vm = Activator.CreateInstance<T>();
            PropertyHelper.SetValues(vm, initParms);
            var context = CreateUniqueWorkSurfaceContextViewModel(vm, workSurfaceContext);
            return context;
        }

        public static WorkSurfaceContextViewModel Create<T>(WorkSurfaceKey key, Tuple<string, object>[] initParms)
            where T : IWorkSurfaceViewModel
        {
            var vm = Activator.CreateInstance<T>();
            PropertyHelper.SetValues(vm, initParms);
            var context = CreateWorkSurfaceContextViewModel(vm, key.WorkSurfaceContext, key);
            return context;
        }
    }
}

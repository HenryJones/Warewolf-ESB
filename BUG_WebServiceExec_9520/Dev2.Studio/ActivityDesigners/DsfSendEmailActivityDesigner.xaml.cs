﻿using System.Activities.Presentation.Model;
using System.Windows;
using System.Windows.Controls;
using Dev2.Activities;
using Dev2.Common;
using Dev2.Common.Enums;
using Dev2.Runtime.ServiceModel.Data;
using Dev2.Studio.AppResources.Converters;
using Dev2.Studio.Core.ViewModels.ActivityViewModels;

namespace Unlimited.Applications.BusinessDesignStudio.Activities
{
    // Interaction logic for DsfSendEmailActivityDesigner.xaml
    public partial class DsfSendEmailActivityDesigner
    {
        #region Fields

        private DsfSendEmailActivity _activity;
        public DsfSendEmailActivityViewModel ViewModel { get; set;}

        #endregion

        public DsfSendEmailActivityDesigner()
        {
            InitializeComponent();                    
        }

        #region Override Methods

        protected override void OnModelItemChanged(object newItem)
        {
            base.OnModelItemChanged(newItem);         
            ModelItem = newItem as ModelItem;
          
                InitializeViewModel(ModelItem);
            
        }

        #endregion Override Methods

        private void InitializeViewModel(ModelItem modelItem)
        {
            _activity = modelItem.GetCurrentValue() as DsfSendEmailActivity;
            if(_activity != null)
            {
                ViewModel = ViewModel ?? new DsfSendEmailActivityViewModel(_activity);               
            }
        }

        void CbxSourceBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CbxSourceBox.IsLoaded && e.AddedItems.Count > 0)
            {               
                EmailSource eSource = e.AddedItems[0] as EmailSource;
                if(eSource != null)
                {
                    ViewModel.FromAccount = eSource.UserName;    
                }
            }
        }
        
    }
}

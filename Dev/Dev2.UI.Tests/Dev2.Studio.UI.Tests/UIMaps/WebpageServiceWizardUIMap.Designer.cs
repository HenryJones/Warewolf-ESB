﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace Dev2.Studio.UI.Tests.UIMaps
{
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class WebpageServiceWizardUIMap
    {
        
        /// <summary>
        /// IsWebpageServiceDetailsWizardOpen
        /// </summary>
        public WpfWindow GetWindow()
        {
            #region Variable Declarations
            WpfWindow uIWebpageServiceDetailWindow = this.UIWebpageServiceDetailWindow;
            #endregion

            return uIWebpageServiceDetailWindow;
        }
        
        #region Properties
        public UIWebpageServiceDetailWindow UIWebpageServiceDetailWindow
        {
            get
            {
                if ((this.mUIWebpageServiceDetailWindow == null))
                {
                    this.mUIWebpageServiceDetailWindow = new UIWebpageServiceDetailWindow();
                }
                return this.mUIWebpageServiceDetailWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIWebpageServiceDetailWindow mUIWebpageServiceDetailWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIWebpageServiceDetailWindow : WpfWindow
    {
        
        public UIWebpageServiceDetailWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.AutomationId] = "WebBrowserWindow";
            this.WindowTitles.Add("Webpage Service Details");
            #endregion
        }
    }
}

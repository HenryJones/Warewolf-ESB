﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

using System.Threading;
using System.Windows.Forms;
using Dev2.CodedUI.Tests;

namespace Dev2.Studio.UI.Tests.UIMaps.DatabaseServiceWizardUIMapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public partial class DatabaseServiceWizardUIMap : UIMapBase
    {
        
        /// <summary>
        /// NewDbSource
        /// </summary>
        public void NewDbSource()
        {
            #region Variable Declarations
            UITestControl uIItemImage = this.UIBusinessDesignStudioWindow.GetChildren()[0].GetChildren()[0];
            #endregion

            // Click image
            Mouse.Click(uIItemImage, new Point(343, 82));
        }
        
        /// <summary>
        /// ClickFirstAction
        /// </summary>
        public void ClickFirstAction()
        {
            UITestControl uIItemImage = this.UIBusinessDesignStudioWindow.GetChildren()[0].GetChildren()[0];
            Mouse.Click(uIItemImage, new Point(172, 164));
        }

        /// <summary>
        /// ClickFirstAction
        /// </summary>
        public void ClickMappingTab()
        {
            UITestControl uIItemImage = this.UIBusinessDesignStudioWindow.GetChildren()[0].GetChildren()[0];
            Playback.Wait(500);
            Mouse.Click(uIItemImage, new Point(280, 25));
        }
        
        /// <summary>
        /// ClickTestAction
        /// </summary>
        public void ClickTestAction()
        {
            #region Variable Declarations
            UITestControl uIItemImage = this.UIBusinessDesignStudioWindow.GetChildren()[0].GetChildren()[0];
            #endregion

            // Click image
            Mouse.Click(uIItemImage, new Point(889, 84));
        }
        
        /// <summary>
        /// ClickOK
        /// </summary>
        public void KeyboardOK()
        {

            SendKeys.SendWait("{TAB}");
            Playback.Wait(20);
            SendKeys.SendWait("{TAB}");
            Playback.Wait(20);
            SendKeys.SendWait("{TAB}");
            Playback.Wait(20);
            SendKeys.SendWait("{TAB}");
            Playback.Wait(20);
            SendKeys.SendWait("{TAB}");
            Playback.Wait(20);
            SendKeys.SendWait("{ENTER}");
            Playback.Wait(20);
        }

        /// <summary>
        /// DatabaseServiceClickCancel
        /// </summary>
        public void ClickCancel()
        {
            UITestControl uIItemImage = this.UIBusinessDesignStudioWindow.GetChildren()[0].GetChildren()[0];
            Mouse.Click(uIItemImage, new Point(874, 533));
        }

        public void InitializeFullTestServiceAndSource(string serverAndSourceCategoryName, string serverAndSourceName)
        {
            //DbSource
            RibbonUIMap.ClickRibbonMenuItem("UI_RibbonHomeTabDBServiceBtn_AutoID");
            WizardsUIMap.WaitForWizard();
            SendKeys.SendWait("{TAB}{TAB}{ENTER}");
            Playback.Wait(10);
            SendKeys.SendWait("RSAKLFSVRGENDEV");
            Playback.Wait(10);
            SendKeys.SendWait("{TAB}{RIGHT}{TAB}");
            Playback.Wait(10);
            SendKeys.SendWait("testuser");
            Playback.Wait(10);
            SendKeys.SendWait("{TAB}");
            Playback.Wait(10);
            SendKeys.SendWait("test123");
            Playback.Wait(10);
            SendKeys.SendWait("{TAB}{ENTER}");
            Playback.Wait(1000);
            SendKeys.SendWait("{TAB}{DOWN}{TAB}{ENTER}{ENTER}");
            Playback.Wait(10);
            SendKeys.SendWait(serverAndSourceCategoryName);
            Playback.Wait(10);
            SendKeys.SendWait("{ENTER}");
            Playback.Wait(1000);
            SendKeys.SendWait("{TAB}{TAB}{TAB}");
            Playback.Wait(10);
            SendKeys.SendWait(serverAndSourceName);
            Playback.Wait(10);
            SendKeys.SendWait("{ENTER}");
            Playback.Wait(1000);
            //DbService
            ClickFirstAction();
            ClickTestAction();
            KeyboardOK();
            SendKeys.SendWait("{ENTER}");
            Playback.Wait(10);
            SendKeys.SendWait(serverAndSourceCategoryName);
            Playback.Wait(10);
            SendKeys.SendWait("{ENTER}{TAB}{TAB}{TAB}");
            Playback.Wait(10);
            SendKeys.SendWait(serverAndSourceName);
            Playback.Wait(10);
            SendKeys.SendWait("{ENTER}");
        }

        public void TabToMappingsTab()
        {
            var wizard = StudioWindow.GetChildren()[0];
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.AllThreads;
            wizard.WaitForControlReady();
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.UIThreadOnly;
            SendKeys.SendWait("{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}{TAB}");
            SendKeys.SendWait("{RIGHT}");
        }

        public void TabToOutputMappings()
        {
            TabToMappingsTab();
            Playback.Wait(500);
            var wizard = StudioWindow.GetChildren()[0];
            Keyboard.SendKeys(wizard, "{TAB}{TAB}{TAB}{TAB}");
            Playback.Wait(200);
        }

        public void TabToInputMappings()
        {
            TabToMappingsTab();
            SendKeys.SendWait("{TAB}");
        }

        public bool IsControlADbServiceWizard(UITestControl wizardWindow)
        {
            return (wizardWindow.ControlType == ControlType.Window && wizardWindow.BoundingRectangle.Width > 900 && wizardWindow.BoundingRectangle.Width < 1000 && wizardWindow.BoundingRectangle.Height > 500 && wizardWindow.BoundingRectangle.Height < 600);
        }

        public void SaveDialogClickFirstFolder()
        {
            #region Variable Declarations
            UITestControl uIItemImage = this.UIBusinessDesignStudioWindow.GetChildren()[0].GetChildren()[0];
            #endregion

            // Click image
            Mouse.Click(uIItemImage, new Point(467, 149));
        }

        /// <summary>
        /// DbServiceClickOK
        /// </summary>
        public void ClickOK()
        {
            UITestControl uIItemImage = this.UIBusinessDesignStudioWindow.GetChildren()[0].GetChildren()[0];

            // Click image
            Mouse.Click(uIItemImage, new Point(774, 520));

        }
        
        #region Properties
        public UIBusinessDesignStudioWindow UIBusinessDesignStudioWindow
        {
            get
            {
                if ((this.mUIBusinessDesignStudioWindow == null))
                {
                    this.mUIBusinessDesignStudioWindow = new UIBusinessDesignStudioWindow();
                }
                return this.mUIBusinessDesignStudioWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIBusinessDesignStudioWindow mUIBusinessDesignStudioWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIBusinessDesignStudioWindow : WpfWindow
    {
        
        public UIBusinessDesignStudioWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.Name, "Warewolf", PropertyExpressionOperator.Contains));
            #endregion
        }
        
        #region Properties
        public UIZ5bc03f5226434284a36Custom UIZ5bc03f5226434284a36Custom
        {
            get
            {
                if ((this.mUIZ5bc03f5226434284a36Custom == null))
                {
                    this.mUIZ5bc03f5226434284a36Custom = new UIZ5bc03f5226434284a36Custom(this);
                }
                return this.mUIZ5bc03f5226434284a36Custom;
            }
        }
        
        public WpfImage UIItemImage
        {
            get
            {
                if ((this.mUIItemImage == null))
                {
                    this.mUIItemImage = new WpfImage(this);
                    #region Search Criteria
                    this.mUIItemImage.WindowTitles.Add(TestBase.GetStudioWindowName());
                    #endregion
                }
                return this.mUIItemImage;
            }
        }
        #endregion
        
        #region Fields
        private UIZ5bc03f5226434284a36Custom mUIZ5bc03f5226434284a36Custom;
        
        private WpfImage mUIItemImage;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIZ5bc03f5226434284a36Custom : WpfCustom
    {
        
        public UIZ5bc03f5226434284a36Custom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "Uia.SplitPane";
            this.SearchProperties["AutomationId"] = "Z5bc03f5226434284a364fdd8116a4038";
            this.WindowTitles.Add(TestBase.GetStudioWindowName());
            #endregion
        }
        
        #region Properties
        public UIUI_TabManager_AutoIDTabList UIUI_TabManager_AutoIDTabList
        {
            get
            {
                if ((this.mUIUI_TabManager_AutoIDTabList == null))
                {
                    this.mUIUI_TabManager_AutoIDTabList = new UIUI_TabManager_AutoIDTabList(this);
                }
                return this.mUIUI_TabManager_AutoIDTabList;
            }
        }
        #endregion
        
        #region Fields
        private UIUI_TabManager_AutoIDTabList mUIUI_TabManager_AutoIDTabList;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIUI_TabManager_AutoIDTabList : WpfTabList
    {
        
        public UIUI_TabManager_AutoIDTabList(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabList.PropertyNames.AutomationId] = "UI_TabManager_AutoID";
            this.WindowTitles.Add(TestBase.GetStudioWindowName());
            #endregion
        }
        
        #region Properties
        public UIStartPageTabPage UIStartPageTabPage
        {
            get
            {
                if ((this.mUIStartPageTabPage == null))
                {
                    this.mUIStartPageTabPage = new UIStartPageTabPage(this);
                }
                return this.mUIStartPageTabPage;
            }
        }
        #endregion
        
        #region Fields
        private UIStartPageTabPage mUIStartPageTabPage;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIStartPageTabPage : WpfTabPage
    {
        
        public UIStartPageTabPage(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabPage.PropertyNames.Name] = "Start Page";
            this.WindowTitles.Add(TestBase.GetStudioWindowName());
            #endregion
        }
        
        #region Properties
        public UIStartPageCustom UIStartPageCustom
        {
            get
            {
                if ((this.mUIStartPageCustom == null))
                {
                    this.mUIStartPageCustom = new UIStartPageCustom(this);
                }
                return this.mUIStartPageCustom;
            }
        }
        #endregion
        
        #region Fields
        private UIStartPageCustom mUIStartPageCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIStartPageCustom : WpfCustom
    {
        
        public UIStartPageCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "Uia.ContentPane";
            this.SearchProperties["AutomationId"] = "splurt";
            this.WindowTitles.Add(TestBase.GetStudioWindowName());
            #endregion
        }
        
        #region Properties
        public WpfImage UIItemImage
        {
            get
            {
                if ((this.mUIItemImage == null))
                {
                    this.mUIItemImage = new WpfImage(this);
                    #region Search Criteria
                    this.mUIItemImage.WindowTitles.Add(TestBase.GetStudioWindowName());
                    #endregion
                }
                return this.mUIItemImage;
            }
        }
        #endregion
        
        #region Fields
        private WpfImage mUIItemImage;
        #endregion
    }
}

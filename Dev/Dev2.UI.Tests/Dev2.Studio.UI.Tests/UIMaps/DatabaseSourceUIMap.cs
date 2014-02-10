﻿using System.Windows;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace Dev2.Studio.UI.Tests.UIMaps.DatabaseSourceUIMapClasses
{
    using System.Drawing;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;

    public partial class DatabaseSourceUIMap : UIMapBase
    {
        public string GetUserName()
        {
            var persistClipboard = Clipboard.GetText();
            var wizard = StudioWindow.GetChildren()[0].GetChildren()[0];
            Mouse.DoubleClick(wizard, new Point(306, 168));
            Keyboard.SendKeys(wizard, "{CTRL}c");
            var userName = Clipboard.GetText();
            Clipboard.SetText(persistClipboard);
            Mouse.Click(wizard, new Point(584, 160));
            return userName;
        }

        public void ChangeAuthenticationTypeToUserFromWindows()
        {
            Keyboard.SendKeys("{TAB}{TAB}{TAB}{RIGHT}");
            Playback.Wait(100);
        }

        public void ChangeAuthenticationTypeToWindowsFromUser()
        {
            Keyboard.SendKeys("{TAB}{TAB}{TAB}{LEFT}");
            Playback.Wait(100);
        }

        public void EnterUsernameAndPassword()
        {
            Keyboard.SendKeys("{TAB}testuser{TAB}test123");
            Playback.Wait(100);
        }

        public void TestConnection()
        {
            Keyboard.SendKeys("{TAB}{ENTER}");
            Playback.Wait(100);
        }

        public void ClickSaveDbConnectionFromTestConnection()
        {
            Keyboard.SendKeys("{TAB}{TAB}{ENTER}");
            Playback.Wait(100);
        }

        public void ClickSaveDbConnectionFromWindowsRadioButton()
        {
            Keyboard.SendKeys("{TAB}{TAB}{ENTER}");
            Playback.Wait(100);
        }
    }
}

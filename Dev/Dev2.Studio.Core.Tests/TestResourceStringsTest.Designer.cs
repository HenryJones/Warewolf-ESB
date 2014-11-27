
/*
*  Warewolf - The Easy Service Bus
*  Copyright 2014 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/


//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dev2.Core.Tests {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class TestResourceStringsTest {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TestResourceStringsTest() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Dev2.Core.Tests.TestResourceStringsTest", typeof(TestResourceStringsTest).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test resource.
        /// </summary>
        public static string displayName {
            get {
                return ResourceManager.GetString("displayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to test.
        /// </summary>
        public static string enviromentModelName {
            get {
                return ResourceManager.GetString("enviromentModelName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \\iconPat.
        /// </summary>
        public static string iconPath {
            get {
                return ResourceManager.GetString("iconPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test resource.
        /// </summary>
        public static string resourceName {
            get {
                return ResourceManager.GetString("resourceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Payload&gt;&lt;Service Name=&quot;TestWorkflowService1&quot; ID=&quot;{0}&quot; ResourceType=&quot;Server&quot; ConnectionString=&quot;AppServerUri=http://rsatest1:77/dsf;WebServerPort=1234&quot;&gt;&lt;/Service&gt;&lt;Service Name=&quot;TestWorkflowService1&quot; ID=&quot;{1}&quot; ResourceType=&quot;Server&quot; ConnectionString=&quot;AppServerUri=http://rsatest2:77/dsf;WebServerPort=1234&quot;&gt;&lt;/Service&gt;&lt;/Payload&gt;.
        /// </summary>
        public static string ResourcesToHydrate {
            get {
                return ResourceManager.GetString("ResourcesToHydrate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://rsatest1:77/dsf.
        /// </summary>
        public static string ResourceToHydrateActualAppUri {
            get {
                return ResourceManager.GetString("ResourceToHydrateActualAppUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AppServerUri=http://rsatest1:77/dsf;WebServerPort=1234.
        /// </summary>
        public static string ResourceToHydrateConnectionString1 {
            get {
                return ResourceManager.GetString("ResourceToHydrateConnectionString1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AppServerUri=http://rsatest2:77/dsf;WebServerPort=1234.
        /// </summary>
        public static string ResourceToHydrateConnectionString2 {
            get {
                return ResourceManager.GetString("ResourceToHydrateConnectionString2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;XMLService&gt;Xml&lt;/XMLService&gt;.
        /// </summary>
        public static string serviceDefinition {
            get {
                return ResourceManager.GetString("serviceDefinition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ! @ #$% ^&amp;* ( ) +_{ }| [] \: &quot;; &apos;&lt;&gt; ?, ./.
        /// </summary>
        public static string SpecialChars {
            get {
                return ResourceManager.GetString("SpecialChars", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Activity mc:Ignorable=&quot;sap&quot; x:Class=&quot;ServiceToBindFrom&quot; xmlns=&quot;http://schemas.microsoft.com/netfx/2009/xaml/activities&quot; xmlns:av=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot; xmlns:mc=&quot;http://schemas.openxmlformats.org/markup-compatibility/2006&quot; xmlns:mva=&quot;clr-namespace:Microsoft.VisualBasic.Activities;assembly=System.Activities&quot; xmlns:s=&quot;clr-namespace:System;assembly=mscorlib&quot; xmlns:sap=&quot;http://schemas.microsoft.com/netfx/2009/xaml/activities/presentation&quot; xmlns:scg=&quot;clr-namespace:System.Col [rest of string was truncated]&quot;;.
        /// </summary>
        public static string TestWorkflowXAML {
            get {
                return ResourceManager.GetString("TestWorkflowXAML", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Inputs&gt;
        ///			&lt;Input Name=&quot;&quot;reg&quot;&quot; Source=&quot;&quot;&quot;&quot; DefaultValue=&quot;&quot;NUD2347&quot;&quot;&gt;
        ///				&lt;Validator Type=&quot;&quot;Required&quot;&quot; /&gt;				
        ///			&lt;/Input&gt;
        ///			&lt;Input Name=&quot;&quot;asdfsad&quot;&quot; Source=&quot;&quot;registration223&quot;&quot; DefaultValue=&quot;&quot;w3rt24324&quot;&quot;&gt;
        ///				&lt;Validator Type=&quot;&quot;Required&quot;&quot; /&gt;				
        ///			&lt;/Input&gt;			
        ///			&lt;Input Name=&quot;&quot;number&quot;&quot; Source=&quot;&quot;&quot;&quot; DefaultValue=&quot;&quot;&quot;&quot;/&gt;
        ///		&lt;/Inputs&gt;.
        /// </summary>
        public static string WebActivity_SavedInputMapping {
            get {
                return ResourceManager.GetString("WebActivity_SavedInputMapping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;WebsiteConfig&gt;
        ///  &lt;CompanyName&gt;
        ///    &lt;Dev2XMLResult&gt;
        ///      &lt;sr&gt;
        ///        &lt;sr&gt;
        ///          &lt;XmlData&gt;
        ///            &lt;XmlData&gt;
        ///              &lt;Dev2ResumeData&gt;
        ///                &lt;XmlData&gt;
        ///                  &lt;Dev2WebServer&gt;http://127.0.0.1:1234&lt;/Dev2WebServer&gt;
        ///                  &lt;XmlData&gt;
        ///                    &lt;Dev2elementNameLabel&gt;cname&lt;/Dev2elementNameLabel&gt;
        ///                    &lt;Dev2displayTextLabel&gt;Acme Development&lt;/Dev2displayTextLabel&gt;
        ///                    &lt;Dev2tabIndexLabel&gt;&lt;/Dev2tabIndexLabel&gt;
        ///            [rest of string was truncated]&quot;;.
        /// </summary>
        public static string WebsiteEditor_Test_Config {
            get {
                return ResourceManager.GetString("WebsiteEditor_Test_Config", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///	&lt;head&gt;
        ///		&lt;title&gt;&lt;Dev2HTML Type=&quot;PageTitle&quot;/&gt;&lt;/title&gt;
        ///		&lt;Dev2HTML Type=&quot;Meta&quot;/&gt;
        ///		&lt;!-- theme css --&gt;
        ///		&lt;link type=&quot;text/css&quot; href=&quot;http://localhost:1234/themes/blacktie/css/ui.custom.css&quot; rel=&quot;stylesheet&quot; /&gt;
        ///		&lt;link type=&quot;text/css&quot; href=&quot;http://localhost:1234/themes/blacktie/css/ui.checkbox.css&quot; rel=&quot;stylesheet&quot; /&gt;
        ///		&lt;link type=&quot;text/css&quot; href=&quot;http://localhost:1234/themes/blacktie/css/ui.selectmenu.css&quot; rel=&quot;stylesheet&quot; /&gt;
        ///		&lt;link type=&quot;text/css&quot; href=&quot;http://localhost:1234/themes/blacktie/c [rest of string was truncated]&quot;;.
        /// </summary>
        public static string WebsiteEditor_Test_HTML {
            get {
                return ResourceManager.GetString("WebsiteEditor_Test_HTML", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;WebsiteConfig&gt;
        ///  &lt;CompanyWrongName&gt;
        ///    &lt;Dev2XMLResult&gt;
        ///      &lt;sr&gt;
        ///        &lt;sr&gt;
        ///          &lt;XmlData&gt;
        ///            &lt;XmlData&gt;
        ///              &lt;Dev2ResumeData&gt;
        ///                &lt;XmlData&gt;
        ///                  &lt;Dev2WebServer&gt;http://127.0.0.1:1234&lt;/Dev2WebServer&gt;
        ///                  &lt;XmlData&gt;
        ///                    &lt;Dev2elementNameLabel&gt;cname&lt;/Dev2elementNameLabel&gt;
        ///                    &lt;Dev2displayTextLabel&gt;Acme Development&lt;/Dev2displayTextLabel&gt;
        ///                    &lt;Dev2tabIndexLabel&gt;&lt;/Dev2tabIndexLabel&gt;
        ///       [rest of string was truncated]&quot;;.
        /// </summary>
        public static string WebsiteEditor_Test_InvalidXmlConfig {
            get {
                return ResourceManager.GetString("WebsiteEditor_Test_InvalidXmlConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Dev2XMLResult&gt;
        ///      &lt;sr&gt;
        ///        &lt;sr&gt;
        ///          &lt;XmlData&gt;
        ///            &lt;XmlData&gt;
        ///              &lt;Dev2ResumeData&gt;
        ///                &lt;XmlData&gt;
        ///                  &lt;Dev2WebServer&gt;http://127.0.0.1:1234&lt;/Dev2WebServer&gt;
        ///                  &lt;XmlData&gt;
        ///                    &lt;Dev2elementNameLabel&gt;cname&lt;/Dev2elementNameLabel&gt;
        ///                    &lt;Dev2displayTextLabel&gt;Acme Development&lt;/Dev2displayTextLabel&gt;
        ///                    &lt;Dev2tabIndexLabel&gt;&lt;/Dev2tabIndexLabel&gt;
        ///                    &lt;Dev2customStyleLabel&gt;&lt;/Dev2c [rest of string was truncated]&quot;;.
        /// </summary>
        public static string WebsiteEditor_Test_Result {
            get {
                return ResourceManager.GetString("WebsiteEditor_Test_Result", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///	&lt;head&gt;
        ///		&lt;title&gt;&lt;Dev2HTML Type=&quot;PageTitle&quot;/&gt;&lt;/title&gt;
        ///		&lt;Dev2HTML Type=&quot;Meta&quot;/&gt;
        ///		&lt;!-- theme css --&gt;
        ///		&lt;link type=&quot;text/css&quot; href=&quot;http://localhost:1234/themes/smoothness/css/ui.custom.css&quot; rel=&quot;stylesheet&quot; /&gt;
        ///		&lt;link type=&quot;text/css&quot; href=&quot;http://localhost:1234/themes/smoothness/css/ui.checkbox.css&quot; rel=&quot;stylesheet&quot; /&gt;
        ///		&lt;link type=&quot;text/css&quot; href=&quot;http://localhost:1234/themes/smoothness/css/ui.selectmenu.css&quot; rel=&quot;stylesheet&quot; /&gt;
        ///		&lt;link type=&quot;text/css&quot; href=&quot;http://localhost:1234/themes/smoo [rest of string was truncated]&quot;;.
        /// </summary>
        public static string websiteEditorValid {
            get {
                return ResourceManager.GetString("websiteEditorValid", resourceCulture);
            }
        }
    }
}

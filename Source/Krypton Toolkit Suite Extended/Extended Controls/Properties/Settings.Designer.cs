﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExtendedControls.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DebugMode {
            get {
                return ((bool)(this["DebugMode"]));
            }
            set {
                this["DebugMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PaletteExplorerLocation {
            get {
                return ((string)(this["PaletteExplorerLocation"]));
            }
            set {
                this["PaletteExplorerLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int DefaultXCoordinate {
            get {
                return ((int)(this["DefaultXCoordinate"]));
            }
            set {
                this["DefaultXCoordinate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int DefaultYCoordinate {
            get {
                return ((int)(this["DefaultYCoordinate"]));
            }
            set {
                this["DefaultYCoordinate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::ComponentFactory.Krypton.Toolkit.KryptonManager GlobalManager {
            get {
                return ((global::ComponentFactory.Krypton.Toolkit.KryptonManager)(this["GlobalManager"]));
            }
            set {
                this["GlobalManager"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Office 2010 - Blue")]
        public global::ComponentFactory.Krypton.Toolkit.PaletteMode DefaultTheme {
            get {
                return ((global::ComponentFactory.Krypton.Toolkit.PaletteMode)(this["DefaultTheme"]));
            }
            set {
                this["DefaultTheme"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("80ada9eb0fd6d87e23d89cf1b4ba84ebd13a99053ec3c2edd26059af2e146ba0")]
        public string VirusTotalAPIKey {
            get {
                return ((string)(this["VirusTotalAPIKey"]));
            }
            set {
                this["VirusTotalAPIKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool VirusTotalUseTLS {
            get {
                return ((bool)(this["VirusTotalUseTLS"]));
            }
            set {
                this["VirusTotalUseTLS"] = value;
            }
        }
    }
}

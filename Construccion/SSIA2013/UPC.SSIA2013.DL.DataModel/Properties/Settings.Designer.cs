﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPC.SSIA2013.DL.DataModel.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=GIORGIO-HP;Initial Catalog=SSIA2013;Persist Security Info=True;User I" +
            "D=sa;Password=password")]
        public string SSIA2013ConnectionString {
            get {
                return ((string)(this["SSIA2013ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=GIORGIO-HP;Initial Catalog=SSIA2013;Persist Security Info=True;User I" +
            "D=sa")]
        public string SSIA2013ConnectionString2 {
            get {
                return ((string)(this["SSIA2013ConnectionString2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=RENZO-PC;Initial Catalog=SSIA2013;User ID=sa;Password=password")]
        public string SSIA2013ConnectionString1 {
            get {
                return ((string)(this["SSIA2013ConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(local);Initial Catalog=SSIA2012-1;User ID=sa;Password=password1!")]
        public string SSIA2012_1ConnectionString {
            get {
                return ((string)(this["SSIA2012_1ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=MB-MROMERO\\MSSQLSERVER2012;Initial Catalog=SSIA2012-1;Integrated Secu" +
            "rity=True")]
        public string SSIA2012_1ConnectionString1 {
            get {
                return ((string)(this["SSIA2012_1ConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=RENZO-PC;Initial Catalog=SSIA2012-1;User ID=sa;Password=password")]
        public string SSIA2012_1ConnectionString2 {
            get {
                return ((string)(this["SSIA2012_1ConnectionString2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(local);Initial Catalog=IFCDC-SSIA2013;User ID=IFCDCadmin;Password=ad" +
            "min")]
        public string IFCDC_SSIA2013ConnectionString {
            get {
                return ((string)(this["IFCDC_SSIA2013ConnectionString"]));
            }
        }
    }
}
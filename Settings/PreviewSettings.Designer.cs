﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xyrus.Apophysis.Settings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    public sealed partial class PreviewSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static PreviewSettings defaultInstance = ((PreviewSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new PreviewSettings())));
        
        public static PreviewSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int EditorPreviewDensityLevel {
            get {
                return ((int)(this["EditorPreviewDensityLevel"]));
            }
            set {
                this["EditorPreviewDensityLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int FlamePropertiesPreviewDensityLevel {
            get {
                return ((int)(this["FlamePropertiesPreviewDensityLevel"]));
            }
            set {
                this["FlamePropertiesPreviewDensityLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int MiniPreviewUpdateResolution {
            get {
                return ((int)(this["MiniPreviewUpdateResolution"]));
            }
            set {
                this["MiniPreviewUpdateResolution"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int MainPreviewDensity {
            get {
                return ((int)(this["MainPreviewDensity"]));
            }
            set {
                this["MainPreviewDensity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public float BatchListPreviewDensity {
            get {
                return ((float)(this["BatchListPreviewDensity"]));
            }
            set {
                this["BatchListPreviewDensity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.1")]
        public float LowQualityDensity {
            get {
                return ((float)(this["LowQualityDensity"]));
            }
            set {
                this["LowQualityDensity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public float MediumQualityDensity {
            get {
                return ((float)(this["MediumQualityDensity"]));
            }
            set {
                this["MediumQualityDensity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public float HighQualityDensity {
            get {
                return ((float)(this["HighQualityDensity"]));
            }
            set {
                this["HighQualityDensity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Size SizePreset1 {
            get {
                return ((global::System.Drawing.Size)(this["SizePreset1"]));
            }
            set {
                this["SizePreset1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Size SizePreset2 {
            get {
                return ((global::System.Drawing.Size)(this["SizePreset2"]));
            }
            set {
                this["SizePreset2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Size SizePreset3 {
            get {
                return ((global::System.Drawing.Size)(this["SizePreset3"]));
            }
            set {
                this["SizePreset3"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int ThreadCount {
            get {
                return ((int)(this["ThreadCount"]));
            }
            set {
                this["ThreadCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int Oversample {
            get {
                return ((int)(this["Oversample"]));
            }
            set {
                this["Oversample"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public float FilterRadius {
            get {
                return ((float)(this["FilterRadius"]));
            }
            set {
                this["FilterRadius"] = value;
            }
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETWControler {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Configuration : global::System.Configuration.ApplicationSettingsBase {
        
        private static Configuration defaultInstance = ((Configuration)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Configuration())));
        
        public static Configuration Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4295")]
        public int PortNumber {
            get {
                return ((int)(this["PortNumber"]));
            }
            set {
                this["PortNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string Host {
            get {
                return ((string)(this["Host"]));
            }
            set {
                this["Host"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8091")]
        public int WCFPort {
            get {
                return ((int)(this["WCFPort"]));
            }
            set {
                this["WCFPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Here it was slow")]
        public string SlowEventMessage {
            get {
                return ((string)(this["SlowEventMessage"]));
            }
            set {
                this["SlowEventMessage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Insert")]
        public string SlowEventHotkey {
            get {
                return ((string)(this["SlowEventHotkey"]));
            }
            set {
                this["SlowEventHotkey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("::.\\Scripts\\xxWPR.cmd -start GeneralProfile")]
        public string LocalTraceStart {
            get {
                return ((string)(this["LocalTraceStart"]));
            }
            set {
                this["LocalTraceStart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("::.\\Scripts\\xxWPR.cmd -stop $FileName  $ScreenshotDir")]
        public string LocalTraceStop {
            get {
                return ((string)(this["LocalTraceStop"]));
            }
            set {
                this["LocalTraceStop"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("::.\\Scripts\\xxWPR.cmd -start GeneralProfile")]
        public string ServerTraceStart {
            get {
                return ((string)(this["ServerTraceStart"]));
            }
            set {
                this["ServerTraceStart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("::.\\Scripts\\xxWPR.cmd -stop $FileName  $ScreenshotDir")]
        public string ServerTraceStop {
            get {
                return ((string)(this["ServerTraceStop"]));
            }
            set {
                this["ServerTraceStop"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LocalTraceEnabled {
            get {
                return ((bool)(this["LocalTraceEnabled"]));
            }
            set {
                this["LocalTraceEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ServerTraceEnabled {
            get {
                return ((bool)(this["ServerTraceEnabled"]));
            }
            set {
                this["ServerTraceEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Here it was fast again")]
        public string FastEventMessage {
            get {
                return ((string)(this["FastEventMessage"]));
            }
            set {
                this["FastEventMessage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Snapshot")]
        public string FastEventHotkey {
            get {
                return ((string)(this["FastEventHotkey"]));
            }
            set {
                this["FastEventHotkey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("c:temp\\ETWControlerScreenshots")]
        public string ScreenshotDirectory {
            get {
                return ((string)(this["ScreenshotDirectory"]));
            }
            set {
                this["ScreenshotDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("::.\\Scripts\\xxWPR.cmd -cancel")]
        public string LocalTraceCancel {
            get {
                return ((string)(this["LocalTraceCancel"]));
            }
            set {
                this["LocalTraceCancel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("::.\\Scripts\\xxWPR.cmd -cancel")]
        public string ServerTraceCancel {
            get {
                return ((string)(this["ServerTraceCancel"]));
            }
            set {
                this["ServerTraceCancel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("c:\\temp\\etwControler%COMPUTERNAME%.etl")]
        public string TraceFileName {
            get {
                return ((string)(this["TraceFileName"]));
            }
            set {
                this["TraceFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2000")]
        public int ForcedScreenshotIntervalinMs {
            get {
                return ((int)(this["ForcedScreenshotIntervalinMs"]));
            }
            set {
                this["ForcedScreenshotIntervalinMs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CaptureKeyboard {
            get {
                return ((bool)(this["CaptureKeyboard"]));
            }
            set {
                this["CaptureKeyboard"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CaptureMouseButtonDown {
            get {
                return ((bool)(this["CaptureMouseButtonDown"]));
            }
            set {
                this["CaptureMouseButtonDown"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int JpgCompressionLevel {
            get {
                return ((int)(this["JpgCompressionLevel"]));
            }
            set {
                this["JpgCompressionLevel"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"
                    <ArrayOfPreset xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
                        <Preset>
                            <Name>Default</Name>
                            <TraceStartCommand>::.\Scripts\xxWPR.cmd -start GeneralProfile</TraceStartCommand>
                            <TraceStopCommand>::.\Scripts\xxWPR.cmd -stop $FileName $ScreenshotDir</TraceStopCommand>
                            <TraceCancelCommand>::.\Scripts\xxWPR.cmd -cancel</TraceCancelCommand>
                        </Preset>
                        <Preset>
                            <Name>Default and .NET</Name>
                            <TraceStartCommand>::.\Scripts\xxWPR.cmd -start GeneralProfile -start DotNET</TraceStartCommand>
                            <TraceStopCommand>::.\Scripts\xxWPR.cmd -stop $FileName $ScreenshotDir</TraceStopCommand>
                            <TraceCancelCommand>::.\Scripts\xxWPR.cmd -cancel</TraceCancelCommand>
                        </Preset>
                    </ArrayOfPreset>
                ")]
        public ETWControler.UI.Preset[] Presets {
            get {
                return ((ETWControler.UI.Preset[])(this["Presets"]));
            }
        }
    }
}

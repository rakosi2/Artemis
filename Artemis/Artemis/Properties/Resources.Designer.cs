﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Artemis.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Artemis.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ambilight {
            get {
                object obj = ResourceManager.GetObject("ambilight", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-16&quot;?&gt;
        ///&lt;Task version=&quot;1.4&quot; xmlns=&quot;http://schemas.microsoft.com/windows/2004/02/mit/task&quot;&gt;
        ///  &lt;RegistrationInfo&gt;
        ///    &lt;Date&gt;2017-11-12T17:45:45.4993602&lt;/Date&gt;
        ///    &lt;Author&gt;{{author}}&lt;/Author&gt;
        ///    &lt;Description&gt;Task to run Artemis on PC startup without showing a UAC dialog&lt;/Description&gt;
        ///    &lt;URI&gt;\Artemis&lt;/URI&gt;
        ///  &lt;/RegistrationInfo&gt;
        ///  &lt;Triggers&gt;
        ///    &lt;LogonTrigger&gt;
        ///      &lt;Enabled&gt;true&lt;/Enabled&gt;
        ///      &lt;Delay&gt;PT30S&lt;/Delay&gt;
        ///    &lt;/LogonTrigger&gt;
        ///  &lt;/Triggers&gt;
        ///  &lt;Principals&gt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Artemis_autorun {
            get {
                return ResourceManager.GetString("Artemis_autorun", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap audio {
            get {
                object obj = ResourceManager.GetObject("audio", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap blackwidow {
            get {
                object obj = ResourceManager.GetObject("blackwidow", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap bow {
            get {
                object obj = ResourceManager.GetObject("bow", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Artemis&quot;
        ///{
        /// &quot;uri&quot; &quot;http://localhost:{{port}}/csgo_game_event&quot;
        /// &quot;timeout&quot; &quot;0.1&quot;
        /// &quot;heartbeat&quot; &quot;0.1&quot;
        /// &quot;data&quot;
        /// {
        ///   &quot;provider&quot;            &quot;1&quot;
        ///   &quot;map&quot;                 &quot;1&quot;
        ///   &quot;round&quot;               &quot;1&quot;
        ///   &quot;player_id&quot;           &quot;1&quot;
        ///   &quot;player_state&quot;        &quot;1&quot;
        ///   &quot;player_weapons&quot;      &quot;1&quot;
        ///   &quot;player_match_stats&quot;  &quot;1&quot;
        /// }
        ///}.
        /// </summary>
        internal static string csgoGamestateConfiguration {
            get {
                return ResourceManager.GetString("csgoGamestateConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] defaultProfiles {
            get {
                object obj = ResourceManager.GetObject("defaultProfiles", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap demo_gif {
            get {
                object obj = ResourceManager.GetObject("demo_gif", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Artemis&quot;
        ///{
        ///    &quot;uri&quot;           &quot;http://localhost:{{port}}/&quot;
        ///    &quot;timeout&quot;       &quot;5.0&quot;
        ///    &quot;buffer&quot;        &quot;0.1&quot;
        ///    &quot;throttle&quot;      &quot;0.1&quot;
        ///    &quot;heartbeat&quot;     &quot;30.0&quot;
        ///    &quot;data&quot;
        ///    {
        ///        &quot;provider&quot;      &quot;1&quot;
        ///        &quot;map&quot;           &quot;1&quot;
        ///        &quot;player&quot;        &quot;1&quot;
        ///        &quot;hero&quot;          &quot;1&quot;
        ///        &quot;abilities&quot;     &quot;1&quot;
        ///        &quot;items&quot;         &quot;1&quot;
        ///    }
        ///}.
        /// </summary>
        internal static string dotaGamestateConfiguration {
            get {
                return ResourceManager.GetString("dotaGamestateConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] ets2_telemetry_server_x64 {
            get {
                object obj = ResourceManager.GetObject("ets2_telemetry_server_x64", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] ets2_telemetry_server_x86 {
            get {
                object obj = ResourceManager.GetObject("ets2_telemetry_server_x86", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap folder {
            get {
                object obj = ResourceManager.GetObject("folder", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap g810 {
            get {
                object obj = ResourceManager.GetObject("g810", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap g910 {
            get {
                object obj = ResourceManager.GetObject("g910", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap generic {
            get {
                object obj = ResourceManager.GetObject("generic", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap gif {
            get {
                object obj = ResourceManager.GetObject("gif", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap headset {
            get {
                object obj = ResourceManager.GetObject("headset", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap k65 {
            get {
                object obj = ResourceManager.GetObject("k65", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap k70 {
            get {
                object obj = ResourceManager.GetObject("k70", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap k95 {
            get {
                object obj = ResourceManager.GetObject("k95", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap k95_platinum {
            get {
                object obj = ResourceManager.GetObject("k95_platinum", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap keypress {
            get {
                object obj = ResourceManager.GetObject("keypress", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] LogitechLED {
            get {
                object obj = ResourceManager.GetObject("LogitechLED", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon logo {
            get {
                object obj = ResourceManager.GetObject("logo", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon logo_disabled {
            get {
                object obj = ResourceManager.GetObject("logo_disabled", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] lua_placeholder {
            get {
                object obj = ResourceManager.GetObject("lua_placeholder", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap masterkeys_pro_l {
            get {
                object obj = ResourceManager.GetObject("masterkeys_pro_l", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap masterkeys_pro_m {
            get {
                object obj = ResourceManager.GetObject("masterkeys_pro_m", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap masterkeys_pro_m1 {
            get {
                object obj = ResourceManager.GetObject("masterkeys_pro_m1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap masterkeys_pro_s {
            get {
                object obj = ResourceManager.GetObject("masterkeys_pro_s", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap mouse {
            get {
                object obj = ResourceManager.GetObject("mouse", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap mousemat {
            get {
                object obj = ResourceManager.GetObject("mousemat", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap none {
            get {
                object obj = ResourceManager.GetObject("none", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap redeemer {
            get {
                object obj = ResourceManager.GetObject("redeemer", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] RzChromaSDK64 {
            get {
                object obj = ResourceManager.GetObject("RzChromaSDK64", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap strafe {
            get {
                object obj = ResourceManager.GetObject("strafe", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] ut_plugin {
            get {
                object obj = ResourceManager.GetObject("ut_plugin", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] witcher3_mod {
            get {
                object obj = ResourceManager.GetObject("witcher3_mod", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] wow_addon {
            get {
                object obj = ResourceManager.GetObject("wow_addon", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}

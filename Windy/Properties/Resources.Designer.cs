﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Windy.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Windy.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to A lightweight window manager to make life easier for users of dockable mobile PCs..
        /// </summary>
        internal static string AboutBox_Blurb {
            get {
                return ResourceManager.GetString("AboutBox_Blurb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;About Windy....
        /// </summary>
        internal static string MenuItem_AboutWindy {
            get {
                return ResourceManager.GetString("MenuItem_AboutWindy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to E&amp;xit.
        /// </summary>
        internal static string MenuItem_Exit {
            get {
                return ResourceManager.GetString("MenuItem_Exit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Restore window layout.
        /// </summary>
        internal static string MenuItem_RestoreWindowLayout {
            get {
                return ResourceManager.GetString("MenuItem_RestoreWindowLayout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Save window layout.
        /// </summary>
        internal static string MenuItem_SaveWindowLayout {
            get {
                return ResourceManager.GetString("MenuItem_SaveWindowLayout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You asked to restore the window layout, but the current display settings don&apos;t match the settings from when you saved the window layout. Do you want to restore the window layout anyway?.
        /// </summary>
        internal static string MessageBoxText_RestoringToNonMatchingScreenLayout {
            get {
                return ResourceManager.GetString("MessageBoxText_RestoringToNonMatchingScreenLayout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windy failed to start.
        /// </summary>
        internal static string MessageBoxText_WindyFailedToStart {
            get {
                return ResourceManager.GetString("MessageBoxText_WindyFailedToStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windy failed to start because its save and restore hotkeys (Ctrl+Win+S and Ctrl+Win+R) are already in use by another application..
        /// </summary>
        internal static string MessageBoxText_WindyFailedToStart_ShortcutsInUse {
            get {
                return ResourceManager.GetString("MessageBoxText_WindyFailedToStart_ShortcutsInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Really restore window layout?.
        /// </summary>
        internal static string MessageBoxTitle_RestoringToNonMatchingScreenLayout {
            get {
                return ResourceManager.GetString("MessageBoxTitle_RestoringToNonMatchingScreenLayout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while trying to restore your window layout: {0} ({1}).
        /// </summary>
        internal static string TipText_CouldntRestoreWindows {
            get {
                return ResourceManager.GetString("TipText_CouldntRestoreWindows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while trying to save your window layout: {0} ({1}).
        /// </summary>
        internal static string TipText_CouldntSaveWindows {
            get {
                return ResourceManager.GetString("TipText_CouldntSaveWindows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your current window layout has been saved..
        /// </summary>
        internal static string TipText_WindowLayoutSaved {
            get {
                return ResourceManager.GetString("TipText_WindowLayoutSaved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windy has automatically restored your window layout because your display settings are now the same as when you saved..
        /// </summary>
        internal static string TipText_WindowsAutomaticallyRestored {
            get {
                return ResourceManager.GetString("TipText_WindowsAutomaticallyRestored", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windy tried to automatically restore your window layout when the monitor layout changed, but encountered an error: {0} ({1}).
        /// </summary>
        internal static string TipText_WindowsNotAutomaticallyRestored {
            get {
                return ResourceManager.GetString("TipText_WindowsNotAutomaticallyRestored", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press Ctrl+Win+S to save the window layout. Windy will restore it automatically when it sees the same display settings again, or manually when you press Ctrl+Win+R..
        /// </summary>
        internal static string TipText_WindyInstructions {
            get {
                return ResourceManager.GetString("TipText_WindyInstructions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windy couldn&apos;t restore your windows.
        /// </summary>
        internal static string TipTitle_CouldntRestoreWindows {
            get {
                return ResourceManager.GetString("TipTitle_CouldntRestoreWindows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windy couldn&apos;t save your windows.
        /// </summary>
        internal static string TipTitle_CouldntSaveWindows {
            get {
                return ResourceManager.GetString("TipTitle_CouldntSaveWindows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Window layout saved.
        /// </summary>
        internal static string TipTitle_WindowLayoutSaved {
            get {
                return ResourceManager.GetString("TipTitle_WindowLayoutSaved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windows automatically restored.
        /// </summary>
        internal static string TipTitle_WindowsAutomaticallyRestored {
            get {
                return ResourceManager.GetString("TipTitle_WindowsAutomaticallyRestored", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windy is running.
        /// </summary>
        internal static string TipTitle_WindyIsRunning {
            get {
                return ResourceManager.GetString("TipTitle_WindyIsRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon windy {
            get {
                object obj = ResourceManager.GetObject("windy", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
    }
}

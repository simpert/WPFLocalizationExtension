﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssemblyTestResourceLib2 {
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
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AssemblyTestResourceLib2.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Aqua.
        /// </summary>
        public static string ButtonAssembly_Background {
            get {
                return ResourceManager.GetString("ButtonAssembly_Background", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change Assembly {0}!.
        /// </summary>
        public static string ButtonAssembly_Content {
            get {
                return ResourceManager.GetString("ButtonAssembly_Content", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LeftToRight.
        /// </summary>
        public static string ButtonAssembly_FlowDirection {
            get {
                return ResourceManager.GetString("ButtonAssembly_FlowDirection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 10,5,20,15.
        /// </summary>
        public static string ButtonAssembly_Margin {
            get {
                return ResourceManager.GetString("ButtonAssembly_Margin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 150.
        /// </summary>
        public static string ButtonAssembly_Width {
            get {
                return ResourceManager.GetString("ButtonAssembly_Width", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GermanTest.
        /// </summary>
        public static string ButtonDE {
            get {
                return ResourceManager.GetString("ButtonDE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to English.
        /// </summary>
        public static string ButtonEN {
            get {
                return ResourceManager.GetString("ButtonEN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap TestImage {
            get {
                object obj = ResourceManager.GetObject("TestImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Another test - just from another assembly..
        /// </summary>
        public static string TestText {
            get {
                return ResourceManager.GetString("TestText", resourceCulture);
            }
        }
    }
}

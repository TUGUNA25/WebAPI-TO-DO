﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TO_DO.API.Infrastructure.Localization {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TO_DO.API.Infrastructure.Localization.ErrorMessages", typeof(ErrorMessages).Assembly);
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
        ///   Looks up a localized string similar to Some Error Occured.
        /// </summary>
        public static string Error {
            get {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User Already Exists.
        /// </summary>
        public static string UserConflict {
            get {
                return ResourceManager.GetString("UserConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User Email should not be empty and should be in a valid format..
        /// </summary>
        public static string UserEmail {
            get {
                return ResourceManager.GetString("UserEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User Firstname should be between 2 and 20 characters..
        /// </summary>
        public static string UserFirstname {
            get {
                return ResourceManager.GetString("UserFirstname", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User Lastname should be between 2 and 30 characters..
        /// </summary>
        public static string UserLastname {
            get {
                return ResourceManager.GetString("UserLastname", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User Not Found.
        /// </summary>
        public static string UserNotFound {
            get {
                return ResourceManager.GetString("UserNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User Phone number should not be empty and should be in a valid format..
        /// </summary>
        public static string UserPhoneNumber {
            get {
                return ResourceManager.GetString("UserPhoneNumber", resourceCulture);
            }
        }
    }
}

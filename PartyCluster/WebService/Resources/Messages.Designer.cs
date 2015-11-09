﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService.Resources {
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
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WebService.Resources.Messages", typeof(Messages).Assembly);
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
        ///   Looks up a localized string similar to Sorry, that cluster doesn&apos;t exist! Please try a different one..
        /// </summary>
        internal static string ClusterDoesNotExist {
            get {
                return ResourceManager.GetString("ClusterDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, this cluster has expired and is being replaced with a new one. Please try a different one..
        /// </summary>
        internal static string ClusterExpired {
            get {
                return ResourceManager.GetString("ClusterExpired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, this cluster is full. Please try a different one..
        /// </summary>
        internal static string ClusterFull {
            get {
                return ResourceManager.GetString("ClusterFull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, this cluster isn&apos;t ready yet. Please try a different in the meantime..
        /// </summary>
        internal static string ClusterNotReady {
            get {
                return ResourceManager.GetString("ClusterNotReady", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please provide a valid email address..
        /// </summary>
        internal static string InvalidArguments {
            get {
                return ResourceManager.GetString("InvalidArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, there are no ports available for your application to use on this cluster. Please try a different one..
        /// </summary>
        internal static string NoPortsAvailable {
            get {
                return ResourceManager.GetString("NoPortsAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, we couldn&apos;t send an invitation to that email. Please check for typos or try a different email..
        /// </summary>
        internal static string SendMailFailed {
            get {
                return ResourceManager.GetString("SendMailFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, something went wrong with this cluster. Please try a different one..
        /// </summary>
        internal static string ServerError {
            get {
                return ResourceManager.GetString("ServerError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You&apos;ve already joined a cluster! You can only join one cluster at a time. When that cluster expires, you can join another one. Please check your email inbox for your invitation (don&apos;t forget to check your junk folder too!)..
        /// </summary>
        internal static string UserAlreadyJoined {
            get {
                return ResourceManager.GetString("UserAlreadyJoined", resourceCulture);
            }
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UltraPasswordGenerator.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("UltraPasswordGenerator.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Не следует использовать последовательную комбинацию цифр («123456», «77777» и т.д.)
        ///Не следует использовать последовательную комбинацию букв на клавиатуре («qwerty» и т.д.)
        ///Комбинируйте врехниий нижний регистры, пунктуацию и цифры
        ///Да,верно, это номер телефона. Попробуйте добавить буквы или пунктуацию
        ///Попробуйте добавить цифры или пунктуацию
        ///Попробуйте добавить буквы или цифры.
        /// </summary>
        internal static string advices {
            get {
                return ResourceManager.GetString("advices", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to a
        ///abandon
        ///abandoned
        ///abate
        ///abbey
        ///abbreviation
        ///ABC
        ///abide
        ///ability
        ///able
        ///aboard
        ///abode
        ///abominable
        ///about
        ///above
        ///abroad
        ///abrupt
        ///abruptly
        ///absence
        ///absent
        ///absolute
        ///absolutely
        ///absorb
        ///absorbed
        ///absorption
        ///abstract
        ///absurd
        ///absurdity
        ///abundance
        ///abundant
        ///acacia
        ///accent
        ///accept
        ///accepted
        ///access
        ///accessible
        ///accident
        ///accidental
        ///accidentally
        ///acclaim
        ///accommodate
        ///accommodation
        ///accompany
        ///accompanying
        ///accomplice
        ///accomplish
        ///accomplished
        ///accord
        ///accordance
        ///according
        ///accordingly
        ///account
        ///accounts
        ///accuracy
        ///accurate
        ///accusation
        ///accuse
        ///accused
        ///accu [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string dictionary {
            get {
                return ResourceManager.GetString("dictionary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1234567890.
        /// </summary>
        internal static string digits {
            get {
                return ResourceManager.GetString("digits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to qwertyuiopasdfghjklzxcvbnm.
        /// </summary>
        internal static string letters {
            get {
                return ResourceManager.GetString("letters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to !&quot;#$%&amp;&apos;()*+,-./:;&lt;=&gt;?@[\]^_`{|}~.
        /// </summary>
        internal static string symbols {
            get {
                return ResourceManager.GetString("symbols", resourceCulture);
            }
        }
    }
}

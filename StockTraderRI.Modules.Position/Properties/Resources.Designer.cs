

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockTraderRI.Modules.Position.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("StockTraderRI.Modules.Position.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;ArrayOfAccountPosition xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///  &lt;AccountPosition&gt;
        ///    &lt;TickerSymbol&gt;STOCK0&lt;/TickerSymbol&gt;
        ///    &lt;CostBasis&gt;280.99&lt;/CostBasis&gt;
        ///    &lt;Shares&gt;10&lt;/Shares&gt;
        ///  &lt;/AccountPosition&gt;
        ///  &lt;AccountPosition&gt;
        ///    &lt;TickerSymbol&gt;STOCK2&lt;/TickerSymbol&gt;
        ///    &lt;CostBasis&gt;1900.22&lt;/CostBasis&gt;
        ///    &lt;Shares&gt;100&lt;/Shares&gt;
        ///  &lt;/AccountPosition&gt;
        ///  &lt;AccountPosition&gt;
        ///    &lt;TickerSymbol&gt;STOCK3&lt;/TickerSymb [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AccountPositions {
            get {
                return ResourceManager.GetString("AccountPositions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shares must be greater than 0.
        /// </summary>
        internal static string InvalidSharesRange {
            get {
                return ResourceManager.GetString("InvalidSharesRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The stop limit price must be greater than 0.
        /// </summary>
        internal static string InvalidStopLimitPrice {
            get {
                return ResourceManager.GetString("InvalidStopLimitPrice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An order has been submitted.
        ///Order Details: {0}.
        /// </summary>
        internal static string LogOrderSubmitted {
            get {
                return ResourceManager.GetString("LogOrderSubmitted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You don&apos;t have {0} shares to sell.
        /// </summary>
        internal static string NotEnoughSharesToSell {
            get {
                return ResourceManager.GetString("NotEnoughSharesToSell", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Limit.
        /// </summary>
        internal static string OrderType_Limit {
            get {
                return ResourceManager.GetString("OrderType_Limit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Market.
        /// </summary>
        internal static string OrderType_Market {
            get {
                return ResourceManager.GetString("OrderType_Market", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stop.
        /// </summary>
        internal static string OrderType_Stop {
            get {
                return ResourceManager.GetString("OrderType_Stop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided String argument {0} must not be null or empty..
        /// </summary>
        internal static string StringCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("StringCannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End of day.
        /// </summary>
        internal static string TimeInForce_EndOfDay {
            get {
                return ResourceManager.GetString("TimeInForce_EndOfDay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thirty days.
        /// </summary>
        internal static string TimeInForce_ThirtyDays {
            get {
                return ResourceManager.GetString("TimeInForce_ThirtyDays", resourceCulture);
            }
        }
    }
}

/*  IMenuItem.cs
*   Author: Nick Monaco
*/
using System.ComponentModel;

namespace DinoDiner.Menu {

    /// <summary>
    /// An interface that acts as a basis for items a customer can order.
    /// </summary>
    public interface IOrderItem {

        /// <summary>
        /// The price of the ordered item.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The description of the ordered item.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// A list of special instructions for food preperation.
        /// </summary>
        string[] Special { get; }


        /// <summary>
        /// The event handler that handles if any properties were changed.
        /// </summary>
        event PropertyChangedEventHandler PropertyChanged;
    }
}

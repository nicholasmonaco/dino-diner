/*  IMenuItem.cs
*   Author: Nick Monaco
*/
using System.Collections.Generic;

namespace DinoDiner.Menu {

    /// <summary>
    /// An interface that acts as a basis for all menu items.
    /// </summary>
    public interface IMenuItem {

        /// <summary>
        /// The price of the menu item.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The calories of the menu item.
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// The ingredients in the menu item.
        /// </summary>
        List<string> Ingredients { get; }
    }
}

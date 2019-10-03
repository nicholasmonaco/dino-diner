/*  Drink.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;

namespace DinoDiner.Menu {

    /// <summary>
    /// Defines the abstract drink object.
    /// </summary>
    public abstract class Drink : IMenuItem {

        /// <summary>
        /// Gets and sets the price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list.
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets and sets the size.
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Gets and sets if the drink contains ice.
        /// </summary>
        public bool Ice { get; set; }


        /// <summary>
        /// Contructor for a generic Drink object.
        /// Sets Ice to true and Size to small by default.
        /// Only usable by subclasses.
        /// </summary>
        protected Drink() {
            Ice = true;
            Size = Size.Small;
        }

        /// <summary>
        /// Sets the Ice property to false.
        /// </summary>
        public void HoldIce() {
            Ice = false;
        }

    }
}

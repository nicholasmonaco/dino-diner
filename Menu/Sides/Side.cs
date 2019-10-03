/*  Side.cs
*   Author: Nathan Bean
*   Modified by: Nick Monaco
*/

using System.Collections.Generic;

namespace DinoDiner.Menu {

    /// <summary>
    /// Defines the abstract side object.
    /// </summary>
    public abstract class Side : IMenuItem {
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
        /// Gets or sets the size.
        /// </summary>
        public abstract Size Size { get; set; }

    }
}

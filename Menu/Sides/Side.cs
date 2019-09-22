/*  Side.cs
*   Author: Nathan Bean
*   Modified by: Nick Monaco
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides {

    /// <summary>
    /// An enum for the size of the side.
    /// </summary>
    public enum Size {
        Small,
        Medium, 
        Large
    }

    /// <summary>
    /// Defines the abstract side object.
    /// </summary>
    public abstract class Side {
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

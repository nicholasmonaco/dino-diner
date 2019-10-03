/*  Entree.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;

namespace DinoDiner.Menu {
    /// <summary>
    /// Defines the abstract Entree object.
    /// </summary>
    public abstract class Entree : IMenuItem {

        /// <summary>
        /// Gets and sets the price of the Entree.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories of the Entree.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the list of ingredients in the Entree.
        /// </summary>
        public abstract List<string> Ingredients { get; }

    }
}

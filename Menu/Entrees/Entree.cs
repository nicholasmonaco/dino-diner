/*  Entree.cs
*   Author: Nick Monaco
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees {
    /// <summary>
    /// Defines the abstract Entree object.
    /// </summary>
    public abstract class Entree {

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

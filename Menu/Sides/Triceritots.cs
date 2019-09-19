/*  Triceritots.cs
*   Author: Nick Monaco
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides {

    /// <summary>
    /// Defines the Triceritots side.
    /// </summary>
    public class Triceritots : Side {

        private Size _size;

        /// <summary>
        /// Constructor for Triceritots, which sets the default size to small.
        /// </summary>
        public Triceritots() {
            Size = Size.Small;
        }

        /// <summary>
        /// Gets the list of ingredients that are in the side.
        /// </summary>
        public override List<string> Ingredients {
            get {
                return new List<string>() { "Potato", "Salt", "Vegtable Oil" };
            }
        }

        /// <summary>
        /// Gets and sets the size of the side.
        /// The setter also adjusts the price and calories of the side accordingly.
        /// </summary>
        public override Size Size {
            get { return _size; }
            set {
                _size = value;
                switch (value) {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
        }
    }
}

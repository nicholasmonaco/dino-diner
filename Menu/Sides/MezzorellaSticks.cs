/*  MezzorellaSticks.cs
*   Author: Nick Monaco
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides {

    /// <summary>
    /// Defines the Mezzorella Sticks side.
    /// </summary>
    public class MezzorellaSticks : Side {

        /// <summary>
        /// Holds the current Size of the side
        /// </summary>
        private Size _size;

        /// <summary>
        /// Constructor for Mezzorella Sticks, which sets the default size to small.
        /// </summary>
        public MezzorellaSticks() {
            Size = Size.Small;
        }

        /// <summary>
        /// Gets the list of ingredients that are in the side.
        /// </summary>
        public override List<string> Ingredients {
            get {
                return new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
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
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
            }
        }

    }
}

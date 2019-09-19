/*  MeteorMacAndCheese.cs
*   Author: Nick Monaco
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides {

    /// <summary>
    /// Defines the Meteor Mac and Cheese side.
    /// </summary>
    public class MeteorMacAndCheese : Side {

        private Size _size;

        /// <summary>
        /// Constructor for Meteor Mac and Cheese, which sets the default size to small.
        /// </summary>
        public MeteorMacAndCheese() {
            Size = Size.Small;
        }

        /// <summary>
        /// Gets the list of ingredients that are in the side.
        /// </summary>
        public override List<string> Ingredients {
            get {
                return new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausuage" };
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
            }
        }

    }
}

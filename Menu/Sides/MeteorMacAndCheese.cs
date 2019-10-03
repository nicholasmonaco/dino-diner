/*  MeteorMacAndCheese.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;

namespace DinoDiner.Menu {

    /// <summary>
    /// Defines the Meteor Mac and Cheese side.
    /// </summary>
    public class MeteorMacAndCheese : Side, IMenuItem {

        /// <summary>
        /// Holds the current Size of the side
        /// </summary>
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
                return new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
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

        /// <summary>
        /// Returns the size and name of the side.
        /// </summary>
        /// <returns>The size and name of the side as a string.</returns>
        public override string ToString() {
            return $"{this.Size} Meteor Mac and Cheese";
        }

    }
}

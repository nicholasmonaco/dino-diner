/*  Sodasaurus.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;

namespace DinoDiner.Menu {

    /// <summary>
    /// An enum for the possible flavors of a Sodasaurus.
    /// </summary>
    public enum SodasaurusFlavor {
        Cola, Orange,
        Vanilla, Chocolate,
        RootBeer, Cherry, Lime
    }

    /// <summary>
    /// Defines the Sodasaurus drink, which extends the abstract Drink class.
    /// </summary>
    public class Sodasaurus : Drink, IMenuItem {

        /// <summary>
        /// Holds the current Size of the drink.
        /// </summary>
        private Size _size;

        /// <summary>
        /// Holds the current flavor of the Sodasaurus.
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }


        /// <summary>
        /// Constructor for Sodasaurus, which sets the default flavor to cola.
        /// It also calls the supercontructor from the Drink class.
        /// </summary>
        public Sodasaurus() : base() {
            Flavor = SodasaurusFlavor.Cola;
        }

        /// <summary>
        /// Gets the list of ingredients that are in the drink.
        /// </summary>
        public override List<string> Ingredients {
            get {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }

        /// <summary>
        /// Gets and sets the size of the drink.
        /// The setter also adjusts the price and calories of the drink accordingly.
        /// </summary>
        public override Size Size {
            get {
                return _size;
            }
            set {
                _size = value;
                switch (value) {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
        }

        /// <summary>
        /// Returns the name and details of the drink.
        /// </summary>
        /// <returns>The name and details of the drink as a string.</returns>
        public override string ToString() {
            return $"{this.Size} {this.Flavor} Sodasaurus";
        }
    }
}

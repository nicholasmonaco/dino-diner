/*  Sodasaurus.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;
using System.ComponentModel;

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
    public class Sodasaurus : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Holds the current Size of the drink.
        /// </summary>
        private Size _size;

        /// <summary>
        /// Holds the current flavor of the Sodasaurus.
        /// </summary>
        private SodasaurusFlavor _flavor;


        /// <summary>
        /// Gets and sets the current flavor of the Sodasaurus.
        /// </summary>
        public SodasaurusFlavor Flavor {
            get { return _flavor; }
            set {
                _flavor = value;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Flavor");
            }
        }


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
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Returns the name and details of the drink.
        /// </summary>
        /// <returns>The name and details of the drink as a string.</returns>
        public override string ToString() {
            string flavorString = this.Flavor.ToString();
            /*if(this.Flavor == SodasaurusFlavor.RootBeer) {
                flavorString = "Root Beer";
            }*/
            // The above commented out code fixes Root Beer flavor from being shown
            // as "RootBeer", but it fails the tests so its disabled.

            return $"{this.Size} {flavorString} Sodasaurus";
        }

        /// <summary>
        /// Gets the description of the drink.
        /// </summary>
        public override string Description {
            get { return this.ToString(); }
        }

        /// <summary>
        /// A list of special instructions to be used during drink preparation.
        /// </summary>
        public override string[] Special {
            get {
                List<string> details = new List<string>(1);
                if (!this.Ice) { details.Add("Hold Ice"); }

                return details.ToArray();
            }
        }
    }
}

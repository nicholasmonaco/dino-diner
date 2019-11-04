/*  Water.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu {

    /// <summary>
    /// Defines the Water drink, which extends the abstract Drink class.
    /// </summary>
    public class Water : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Holds the current size of the drink.
        /// </summary>
        private Size _size;

        /// <summary>
        /// Holds the value of whether the drink has lemon or not.
        /// </summary>
        private bool _lemon;


        /// <summary>
        /// Gets and sets if the drink has a lemon slice in it.
        /// </summary>
        public bool Lemon {
            get { return _lemon; }
            set {
                _lemon = value;
                NotifyOfPropertyChanged("Lemon");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Constructor for Water, which sets it to not have lemon by default.
        /// The default price and calories are set to $0.10 and 0, respectively.
        /// It also calls the supercontructor from the Drink class.
        /// </summary>
        public Water() : base() {
            Price = 0.10;
            Calories = 0;
            Lemon = false;
        }

        /// <summary>
        /// Sets the Lemon property to true.
        /// </summary>
        public void AddLemon() {
            Lemon = true;
        }

        /// <summary>
        /// Gets the list of ingredients that are in the drink.
        /// </summary>
        public override List<string> Ingredients {
            get {
                List<string> i = new List<string>() { "Water" };
                if (Lemon) { i.Add("Lemon"); }
                return i;
            }
        }

        /// <summary>
        /// Gets and sets the size of the drink.
        /// </summary>
        public override Size Size {
            get { return _size; }
            set {
                _size = value;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Price"); //This and calories never change with water, but whatever.
                NotifyOfPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// Returns the size and name of the drink.
        /// </summary>
        /// <returns>The size and name of the drink as a string.</returns>
        public override string ToString() {
            return $"{this.Size} Water";
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
                List<string> details = new List<string>(2);
                if (!this.Ice) { details.Add("Hold Ice"); }
                if (this.Lemon) { details.Add("Add Lemon"); }

                return details.ToArray();
            }
        }
    }
}

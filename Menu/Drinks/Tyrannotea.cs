/*  Tyrannotea.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu {

    /// <summary>
    /// Defines the Tyrannotea drink, which extends the abstract Drink class.
    /// </summary>
    public class Tyrannotea : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Holds the current Size of the drink.
        /// </summary>
        private Size _size;

        /// <summary>
        /// Holds the value of whether the drink has lemon or not.
        /// </summary>
        private bool _lemon;

        /// <summary>
        /// Holds if the Tyrannotea is sweet or not.
        /// </summary>
        private bool _sweet;

        /// <summary>
        /// Gets and sets if the Tyrannotea is sweet or not.
        /// The setter also doubles/halves the calories of the drink, depending on if 
        /// the tea is being sweetened/unsweetened.
        /// </summary>
        public bool Sweet {
            get {
                return this._sweet;
            }
            set {
                bool temp = this._sweet;
                this._sweet = value;
                if (temp != value) {
                    if (value) { this.Calories *= 2; } 
                    else { this.Calories /= 2; }
                }
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Sweet");
            }
        }

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
        /// Constructor for Tyrannotea, which sets it to not be sweet or have lemon by default.
        /// It also calls the supercontructor from the Drink class.
        /// </summary>
        public Tyrannotea() : base() {
            Sweet = false;
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
                List<string> i = new List<string>() { "Water", "Tea" };
                if (Lemon) { i.Add("Lemon"); }
                if (Sweet) { i.Add("Cane Sugar"); }
                return i;
            }
        }

        /// <summary>
        /// Gets and sets the size of the drink.
        /// The setter also adjusts the price and calories of the drink accordingly.
        /// If the Tyrannotea is sweetened/unsweetened is also taken into account with the calorie change.
        /// </summary>
        public override Size Size {
            get {
                return _size;
            }
            set {
                _size = value;
                switch (value) {
                    case Size.Small:
                        Price = 0.99;
                        if (!Sweet) { Calories = 8; } 
                        else { Calories = 16; }
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        if (!Sweet) { Calories = 16; } 
                        else { Calories = 32; }
                        break;
                    case Size.Large:
                        Price = 1.99;
                        if (!Sweet) { Calories = 32; } 
                        else { Calories = 64; }
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
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Size.ToString());
            if(Sweet) { sb.Append(" Sweet"); }
            sb.Append(" Tyrannotea");
            return sb.ToString();
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
                List<string> details = new List<string>(3);
                if (!this.Ice) { details.Add("Hold Ice"); }
                if (this.Lemon) { details.Add("Add Lemon"); }

                return details.ToArray();
            }
        }
    }
}

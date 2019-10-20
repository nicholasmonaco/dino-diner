/*  JurassicJava.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu {

    /// <summary>
    /// Defines the JurassicJava drink, which extends the abstract Drink class.
    /// </summary>
    public class JurassicJava : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Holds the current Size of the drink.
        /// </summary>
        private Size _size;

        /// <summary>
        /// Holds if there should be room for cream in the drink.
        /// </summary>
        private bool _roomForCream;

        /// <summary>
        /// Holds if the Jurassic Java should be decaf.
        /// </summary>
        private bool _decaf;


        /// <summary>
        /// Gets and sets if the JurassicJava should leave room for cream.
        /// </summary>
        public bool RoomForCream {
            get { return _roomForCream; }
            set {
                _roomForCream = value;
                NotifyOfPropertyChanged("RoomForCream");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Gets and sets if the JurassicJava should be decaf or not.
        /// </summary>
        public bool Decaf {
            get { return _decaf; }
            set {
                _decaf = value;
                NotifyOfPropertyChanged("Decaf");
                NotifyOfPropertyChanged("Description");
            }
        }


        /// <summary>
        /// Constructor for JurassicJava, which sets Ice, RoomForCream, and Decaf to false by default.
        /// It also calls the supercontructor from the Drink class.
        /// </summary>
        public JurassicJava() : base() {
            Ice = false;
            RoomForCream = false;
            Decaf = false;
        }

        /// <summary>
        /// Sets the RoomForCream property to true.
        /// </summary>
        public void LeaveRoomForCream() {
            RoomForCream = true;
        }

        /// <summary>
        /// Sets the Ice property to true;
        /// </summary>
        public void AddIce() {
            Ice = true;
        }

        /// <summary>
        /// Gets the list of ingredients that are in the drink.
        /// </summary>
        public override List<string> Ingredients {
            get {
                return new List<string>() { "Water", "Coffee" };
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
                        Price = 0.59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
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
            if (Decaf) { sb.Append(" Decaf"); }
            sb.Append(" Jurassic Java");
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
                if (this.Ice) { details.Add("Add Ice"); }
                if (this.RoomForCream) { details.Add("Leave Room For Cream"); }

                return details.ToArray();
            }
        }
    }
}

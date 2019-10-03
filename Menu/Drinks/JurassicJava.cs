/*  JurassicJava.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu {

    /// <summary>
    /// Defines the JurassicJava drink, which extends the abstract Drink class.
    /// </summary>
    public class JurassicJava : Drink, IMenuItem {

        /// <summary>
        /// Holds the current Size of the drink.
        /// </summary>
        private Size _size;

        /// <summary>
        /// Gets and sets if the JurassicJava should leave room for cream.
        /// </summary>
        public bool RoomForCream { get; set; }

        /// <summary>
        /// Gets and sets if the JurassicJava should be decaf or not.
        /// </summary>
        public bool Decaf { get; set; }


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
    }
}

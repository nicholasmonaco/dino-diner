/*  Water.cs
*   Author: Nick Monaco
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks {

    /// <summary>
    /// Defines the Water drink, which extends the abstract Drink class.
    /// </summary>
    public class Water : Drink {

        /// <summary>
        /// Gets and sets if the drink has a lemon slice in it.
        /// </summary>
        public bool Lemon { get; set; }

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
        public override Size Size { get; set; }
    }
}

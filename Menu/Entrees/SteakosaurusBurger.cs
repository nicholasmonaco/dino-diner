/*  SteakosaurusBurger.cs
*   Author: Nick Monaco
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees {
    /// <summary>
    /// Defines the Steakosaurus Burger entree.
    /// </summary>
    public class SteakosaurusBurger {
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        /// <summary>
        /// Defines the ingredients that exist in the entree.
        /// </summary>
        public List<string> Ingredients {
            get {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for the Steakosaurus Burger entree.
        /// </summary>
        public SteakosaurusBurger() {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Holds the whole wheat bun from the entree.
        /// </summary>
        public void HoldBun() {
            this.bun = false;
        }

        /// <summary>
        /// Holds the pickle from the entree.
        /// </summary>
        public void HoldPickle() {
            this.pickle = false;
        }

        /// <summary>
        /// Holds the ketchup from the entree.
        /// </summary>
        public void HoldKetchup() {
            this.ketchup = false;
        }

        /// <summary>
        /// Holds the mustard from the entree.
        /// </summary>
        public void HoldMustard() {
            this.mustard = false;
        }
    }
}

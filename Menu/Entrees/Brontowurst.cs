/*  Brontowurst.cs
*   Author: Nick Monaco
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees {
    /// <summary>
    /// Defines the Brontowurst entree.
    /// </summary>
    public class Brontowurst : Entree {

        private bool bun = true;
        private bool peppers = true;
        private bool onion = true;

        /// <summary>
        /// Defines the ingredients that exist in the entree.
        /// </summary>
        public override List<string> Ingredients {
            get {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for the Brontowurst entree.
        /// </summary>
        public Brontowurst() {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Holds the whole wheat bun from the entree.
        /// </summary>
        public void HoldBun() {
            this.bun = false;
        }

        /// <summary>
        /// Holds the peppers from the entree.
        /// </summary>
        public void HoldPeppers() {
            this.peppers = false;
        }

        /// <summary>
        /// Holds the onion from the entree.
        /// </summary>
        public void HoldOnion() {
            this.onion = false;
        }

    }
}

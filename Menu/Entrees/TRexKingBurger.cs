/*  TRexKingBurger.cs
*   Author: Nick Monaco
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees {
    /// <summary>
    /// Defines the T-Rex King Burger entree.
    /// </summary>
    public class TRexKingBurger {

        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        /// <summary>
        /// Defines the ingredients that exist in the entree.
        /// </summary>
        public List<string> Ingredients {
            get {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for the T-Rex King Burger entree.
        /// </summary>
        public TRexKingBurger() {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// Holds the whole wheat bun from the entree.
        /// </summary>
        public void HoldBun() {
            this.bun = false;
        }

        /// <summary>
        /// Holds the lettuce from the entree.
        /// </summary>
        public void HoldLettuce() {
            this.lettuce = false;
        }

        /// <summary>
        /// Holds the tomato from the entree.
        /// </summary>
        public void HoldTomato() {
            this.tomato = false;
        }

        /// <summary>
        /// Holds the onion from the entree.
        /// </summary>
        public void HoldOnion() {
            this.onion = false;
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

        /// <summary>
        /// Holds the mayo from the entree.
        /// </summary>
        public void HoldMayo() {
            this.mayo = false;
        }
    }
}

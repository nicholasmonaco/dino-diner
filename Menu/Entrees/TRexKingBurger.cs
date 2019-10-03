/*  TRexKingBurger.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;

namespace DinoDiner.Menu {
    /// <summary>
    /// Defines the T-Rex King Burger entree.
    /// </summary>
    public class TRexKingBurger : Entree, IMenuItem {

        /// <summary>
        /// Indicates if the entree has a bun.
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Indicates if the entree has lettuce.
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Indicates if the entree has tomato.
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// Indicates if the entree has onion.
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// Indicates if the entree has pickles.
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// Indicates if the entree has ketchup.
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// Indicates if the entree has mustard.
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// Indicates if the entree has mayo.
        /// </summary>
        private bool mayo = true;


        /// <summary>
        /// Defines the ingredients that exist in the entree.
        /// </summary>
        public override List<string> Ingredients {
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

        /// <summary>
        /// Returns the name of the entree.
        /// </summary>
        /// <returns>The name of the entree as a string.</returns>
        public override string ToString() {
            return "T-Rex King Burger";
        }
    }
}

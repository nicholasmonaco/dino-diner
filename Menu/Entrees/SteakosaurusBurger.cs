/*  SteakosaurusBurger.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu {
    /// <summary>
    /// Defines the Steakosaurus Burger entree.
    /// </summary>
    public class SteakosaurusBurger : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Indicates if the entree has a bun.
        /// </summary>
        private bool bun = true;

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
        /// Defines the ingredients that exist in the entree.
        /// </summary>
        public override List<string> Ingredients {
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
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the pickle from the entree.
        /// </summary>
        public void HoldPickle() {
            this.pickle = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the ketchup from the entree.
        /// </summary>
        public void HoldKetchup() {
            this.ketchup = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the mustard from the entree.
        /// </summary>
        public void HoldMustard() {
            this.mustard = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns the name of the entree.
        /// </summary>
        /// <returns>The name of the entree as a string.</returns>
        public override string ToString() {
            return "Steakosaurus Burger";
        }

        /// <summary>
        /// Gets the description of the Entree.
        /// </summary>
        public override string Description {
            get { return this.ToString(); }
        }

        /// <summary>
        /// A list of special instructions to be used during food preparation.
        /// </summary>
        public override string[] Special {
            get {
                List<string> details = new List<string>(4);
                if (!this.bun) { details.Add("Hold Bun"); }
                if (!this.pickle) { details.Add("Hold Pickle"); }
                if (!this.ketchup) { details.Add("Hold Ketchup"); }
                if (!this.mustard) { details.Add("Hold Mustard"); }

                return details.ToArray();
            }
        }
    }
}

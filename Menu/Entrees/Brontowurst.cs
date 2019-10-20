/*  Brontowurst.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu {
    /// <summary>
    /// Defines the Brontowurst entree.
    /// </summary>
    public class Brontowurst : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Indicates if the entree has a bun.
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Indicates if the entree has peppers.
        /// </summary>
        private bool peppers = true;

        /// <summary>
        /// Indicates if the entree has onion.
        /// </summary>
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
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the peppers from the entree.
        /// </summary>
        public void HoldPeppers() {
            this.peppers = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the onion from the entree.
        /// </summary>
        public void HoldOnion() {
            this.onion = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns the name of the entree.
        /// </summary>
        /// <returns>The name of the entree as a string.</returns>
        public override string ToString() {
            return "Brontowurst";
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
                List<string> details = new List<string>(3);
                if (!this.bun) { details.Add("Hold Bun"); }
                if (!this.peppers) { details.Add("Hold Peppers"); }
                if (!this.onion) { details.Add("Hold Onion"); }

                return details.ToArray();
            }
        }
    }
}

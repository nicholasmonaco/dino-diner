/*  TRexKingBurger.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu {
    /// <summary>
    /// Defines the T-Rex King Burger entree.
    /// </summary>
    public class TRexKingBurger : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged {

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
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the lettuce from the entree.
        /// </summary>
        public void HoldLettuce() {
            this.lettuce = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the tomato from the entree.
        /// </summary>
        public void HoldTomato() {
            this.tomato = false;
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
        /// Holds the mayo from the entree.
        /// </summary>
        public void HoldMayo() {
            this.mayo = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns the name of the entree.
        /// </summary>
        /// <returns>The name of the entree as a string.</returns>
        public override string ToString() {
            return "T-Rex King Burger";
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
                List<string> details = new List<string>(8);
                if (!this.bun) { details.Add("Hold Bun"); }
                if (!this.lettuce) { details.Add("Hold Lettuce"); }
                if (!this.tomato) { details.Add("Hold Tomato"); }
                if (!this.onion) { details.Add("Hold Onion"); }
                if (!this.pickle) { details.Add("Hold Pickle"); }
                if (!this.ketchup) { details.Add("Hold Ketchup"); }
                if (!this.mustard) { details.Add("Hold Mustard"); }
                if (!this.mayo) { details.Add("Hold Mayo"); }

                return details.ToArray();
            }
        }
    }
}

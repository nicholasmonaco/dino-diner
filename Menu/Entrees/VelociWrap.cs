/*  VelociWrap.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu {
    /// <summary>
    /// Defines the Veloci-Wrap entree.
    /// </summary>
    public class VelociWrap : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Indicates if the entree has dressing.
        /// </summary>
        private bool dressing = true;

        /// <summary>
        /// Indicates if the entree has lettuce.
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Indicates if the entree has cheese.
        /// </summary>
        private bool cheese = true;


        /// <summary>
        /// Defines the ingredients that exist in the entree.
        /// </summary>
        public override List<string> Ingredients {
            get {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for the Veloci-Wrap entree.
        /// </summary>
        public VelociWrap() {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Holds the Ceasar dressing from the entree.
        /// </summary>
        public void HoldDressing() {
            this.dressing = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the romaine lettuce from the entree.
        /// </summary>
        public void HoldLettuce() {
            this.lettuce = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the parmesan cheese from the entree.
        /// </summary>
        public void HoldCheese() {
            this.cheese = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns the name of the entree.
        /// </summary>
        /// <returns>The name of the entree as a string.</returns>
        public override string ToString() {
            return "Veloci-Wrap";
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
                if (!this.dressing) { details.Add("Hold Dressing"); }
                if (!this.lettuce) { details.Add("Hold Lettuce"); }
                if (!this.cheese) { details.Add("Hold Cheese"); }
                return details.ToArray();
            }
        }
    }
}

/*  VelociWrap.cs
*   Author: Nick Monaco
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees {
    /// <summary>
    /// Defines the Veloci-Wrap entree.
    /// </summary>
    public class VelociWrap : Entree{

        private bool dressing = true;
        private bool lettuce = true;
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
        }

        /// <summary>
        /// Holds the romaine lettuce from the entree.
        /// </summary>
        public void HoldLettuce() {
            this.lettuce = false;
        }

        /// <summary>
        /// Holds the parmesan cheese from the entree.
        /// </summary>
        public void HoldCheese() {
            this.cheese = false;
        }
    }
}

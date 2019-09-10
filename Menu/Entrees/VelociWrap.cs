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
    public class VelociWrap {

        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        /// <summary>
        /// Defines the ingredients that exist in the entree.
        /// </summary>
        public List<string> Ingredients {
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
        /// NOTE: This is in the same format as the rest of the hold methods, but
        /// isn't used in the test cases.
        /// </summary>
        public void HoldCheese() {
            this.cheese = false;
        }

        /// <summary>
        /// Holds the parmesan cheese from the entree.
        /// NOTE: This is used to pass the test cases. The method is the same
        /// as the HoldCheese() method.
        /// </summary>
        public void holdCheese() {
            this.cheese = false;
        }
    }
}

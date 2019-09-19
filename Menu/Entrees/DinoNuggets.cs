/*  DinoNuggets.cs
*   Author: Nick Monaco
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees {
    /// <summary>
    /// Defines the Dino Nuggets entree.
    /// </summary>
    public class DinoNuggets : Entree {

        private int nugCount = 6;

        /// <summary>
        /// Defines the ingredients that exist in the entree.
        /// Each Dino Nugget is considered a seperate ingredient.
        /// </summary>
        public override List<string> Ingredients {
            get {
                List<string> ingredients = new List<string>();
                for(int i = 0; i < nugCount; i++) {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for the Dino Nuggets entree.
        /// </summary>
        public DinoNuggets() {
            this.Price = 4.25;
            this.Calories = 59*6;
        }

        /// <summary>
        /// Adds one more nugget to Ingredients.
        /// This method also updates nugCount, Price, and Calories accordingly.
        /// </summary>
        public void AddNugget() {
            nugCount++;
            this.Price += 0.25;
            this.Calories += 59;
            Ingredients.Add("Chicken Nugget");
        }
    }
}

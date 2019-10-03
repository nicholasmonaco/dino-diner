/*  DinoNuggets.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;

namespace DinoDiner.Menu {
    /// <summary>
    /// Defines the Dino Nuggets entree.
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem {

        /// <summary>
        /// Indicates how many nuggets are in the entree.
        /// </summary>
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

        /// <summary>
        /// Returns the name of the entree.
        /// </summary>
        /// <returns>The name of the entree as a string.</returns>
        public override string ToString() {
            return "Dino-Nuggets";
        }
    }
}

/*  PterodactylWings.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;

namespace DinoDiner.Menu {
    /// <summary>
    /// Defines the Pterodactyl Wings entree.
    /// </summary>
    public class PterodactylWings : Entree, IMenuItem {

        /// <summary>
        /// Defines the ingredients that exist in the entree.
        /// </summary>
        public override List<string> Ingredients {
            get {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for the Pterodactyl Wings entree.
        /// </summary>
        public PterodactylWings() {
            this.Price = 7.21;
            this.Calories = 318;
        }


        /// <summary>
        /// Returns the name of the entree.
        /// </summary>
        /// <returns>The name of the entree as a string.</returns>
        public override string ToString() {
            return "Pterodactyl Wings";
        }
    }
}

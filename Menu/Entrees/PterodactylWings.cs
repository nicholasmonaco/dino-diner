/*  PterodactylWings.cs
*   Author: Nick Monaco
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees {
    /// <summary>
    /// Defines the Pterodactyl Wings entree.
    /// </summary>
    public class PterodactylWings {

        public double Price { get; set; }
        public uint Calories { get; set; }

        /// <summary>
        /// Defines the ingredients that exist in the entree.
        /// </summary>
        public List<string> Ingredients {
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
    }
}

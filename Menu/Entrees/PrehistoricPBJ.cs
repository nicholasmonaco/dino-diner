/*  PrehistoricPBJ.cs
*   Author: Nathan Bean
*   Modified by: Nick Monaco
*/

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Defines the Prehistoric PB&J entree.
    /// </summary>
    public class PrehistoricPBJ : Entree, IMenuItem {

        /// <summary>
        /// Indicates if the entree has peanut butter.
        /// </summary>
        private bool peanutButter = true;

        /// <summary>
        /// Indicates if the entree has jelly.
        /// </summary>
        private bool jelly = true;


        /// <summary>
        /// Defines the ingredients that exist in the entree.
        /// </summary>
        public override List<string> Ingredients{
            get{
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for the Prehistoric PB&J entree.
        /// </summary>
        public PrehistoricPBJ(){
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Holds the peanut butter from the entree.
        /// </summary>
        public void HoldPeanutButter(){
            this.peanutButter = false;
        }

        /// <summary>
        /// Holds the jelly from the entree.
        /// </summary>
        public void HoldJelly(){
            this.jelly = false;
        }

        /// <summary>
        /// Returns the name of the entree.
        /// </summary>
        /// <returns>The name of the entree as a string.</returns>
        public override string ToString() {
            return "Prehistoric PB&J";
        }
    }
}

/*  PrehistoricPBJ.cs
*   Author: Nathan Bean
*   Modified by: Nick Monaco
*/

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Defines the Prehistoric PB&J entree.
    /// </summary>
    public class PrehistoricPBJ : Entree {

        private bool peanutButter = true;
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
    }
}

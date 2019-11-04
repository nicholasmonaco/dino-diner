/*  PterodactylWings.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu {
    /// <summary>
    /// Defines the Pterodactyl Wings entree.
    /// </summary>
    public class PterodactylWings : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged {

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
        /// Changes the specified holdable ingredient to the specified value.
        /// Nothing can be held from Pterodactyl Wings, but the method is here regardless.
        /// </summary>
        /// <param name="index">The index of the holdable ingredient.</param>
        /// <param name="newVal">The new value of whether or not the ingredient should be held.</param>
        public override void ChangeHold(int index, bool newVal) {

            NotifyOfPropertyChanged("Special");
        }


        /// <summary>
        /// Returns the name of the entree.
        /// </summary>
        /// <returns>The name of the entree as a string.</returns>
        public override string ToString() {
            return "Pterodactyl Wings";
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
            get { return new string[0]; }
        }
    }
}

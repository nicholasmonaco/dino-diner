/*  PrehistoricPBJ.cs
*   Author: Nathan Bean
*   Modified by: Nick Monaco
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Defines the Prehistoric PB&J entree.
    /// </summary>
    public class PrehistoricPBJ : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Indicates if the entree has peanut butter.
        /// </summary>
        public bool PeanutButter { get; set; } = true;

        /// <summary>
        /// Indicates if the entree has jelly.
        /// </summary>
        public bool Jelly { get; set; } = true;


        /// <summary>
        /// Defines the ingredients that exist in the entree.
        /// </summary>
        public override List<string> Ingredients{
            get{
                List<string> ingredients = new List<string>() { "Bread" };
                if (PeanutButter) ingredients.Add("Peanut Butter");
                if (Jelly) ingredients.Add("Jelly");
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
        /// Changes the specified holdable ingredient to the specified value.
        /// </summary>
        /// <param name="index">The index of the holdable ingredient.</param>
        /// <param name="newVal">The new value of whether or not the ingredient should be held.</param>
        public override void ChangeHold(int index, bool newVal) {
            switch (index) {
                case 0:
                    PeanutButter = newVal;
                    break;
                case 1:
                    Jelly = newVal;
                    break;
            }

            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the peanut butter from the entree.
        /// </summary>
        public void HoldPeanutButter(){
            this.PeanutButter = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the jelly from the entree.
        /// </summary>
        public void HoldJelly(){
            this.Jelly = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns the name of the entree.
        /// </summary>
        /// <returns>The name of the entree as a string.</returns>
        public override string ToString() {
            return "Prehistoric PB&J";
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
                List<string> details = new List<string>(2);
                if (!this.PeanutButter) { details.Add("Hold Peanut Butter"); }
                if (!this.Jelly) { details.Add("Hold Jelly"); }

                return details.ToArray();
            }
        }
    }
}

/*  DinoNuggets.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu {
    /// <summary>
    /// Defines the Dino Nuggets entree.
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Indicates how many nuggets are in the entree.
        /// </summary>
        public int NuggetCount { get; private set; } = 6;

        /// <summary>
        /// Defines the ingredients that exist in the entree.
        /// Each Dino Nugget is considered a seperate ingredient.
        /// </summary>
        public override List<string> Ingredients {
            get {
                List<string> ingredients = new List<string>();
                for(int i = 0; i < NuggetCount; i++) {
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
        /// Changes the specified holdable ingredient to the specified value.
        /// Unused in DinoNugget.
        /// </summary>
        /// <param name="index">The index of the holdable ingredient.</param>
        /// <param name="newVal">The new value of whether or not the ingredient should be held.</param>
        public override void ChangeHold(int index, bool newVal) {

            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Adds one more nugget to Ingredients.
        /// This method also updates nugCount, Price, and Calories accordingly.
        /// </summary>
        public void AddNugget() {
            NuggetCount++;
            this.Price += 0.25;
            this.Calories += 59;
            Ingredients.Add("Chicken Nugget");

            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes an extra nugget, if there are any.
        /// This method also updates nugCount, Price, and Calories accordingly.
        /// </summary>
        public void RemoveNugget() {
            if(NuggetCount > 6) {
                NuggetCount--;
                this.Price -= 0.25;
                this.Calories -= 59;
                Ingredients.Remove("Chicken Nugget");

                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Returns the name of the entree.
        /// </summary>
        /// <returns>The name of the entree as a string.</returns>
        public override string ToString() {
            return "Dino-Nuggets";
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
                List<string> details = new List<string>(1);

                if (this.NuggetCount == 7) {
                    details.Add("Add 1 Extra Nugget");
                }else if(this.NuggetCount > 7) {
                    details.Add($"Add {NuggetCount - 6} Extra Nuggets");
                }

                return details.ToArray();
            }
        }
    }
}

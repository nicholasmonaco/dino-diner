/*  VelociWrap.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu {
    /// <summary>
    /// Defines the Veloci-Wrap entree.
    /// </summary>
    public class VelociWrap : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Indicates if the entree has dressing.
        /// </summary>
        public bool Dressing { get; set; } = true;

        /// <summary>
        /// Indicates if the entree has lettuce.
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Indicates if the entree has cheese.
        /// </summary>
        public bool Cheese { get; set; } = true;


        /// <summary>
        /// Defines the ingredients that exist in the entree.
        /// </summary>
        public override List<string> Ingredients {
            get {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (Dressing) ingredients.Add("Ceasar Dressing");
                if (Lettuce) ingredients.Add("Romaine Lettuce");
                if (Cheese) ingredients.Add("Parmesan Cheese");
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
        /// Changes the specified holdable ingredient to the specified value.
        /// </summary>
        /// <param name="index">The index of the holdable ingredient.</param>
        /// <param name="newVal">The new value of whether or not the ingredient should be held.</param>
        public override void ChangeHold(int index, bool newVal) {
            switch (index) {
                case 0:
                    Dressing = newVal;
                    break;
                case 1:
                    Lettuce = newVal;
                    break;
                case 2:
                    Cheese = newVal;
                    break;
            }

            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the Ceasar dressing from the entree.
        /// </summary>
        public void HoldDressing() {
            this.Dressing = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the romaine lettuce from the entree.
        /// </summary>
        public void HoldLettuce() {
            this.Lettuce = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the parmesan cheese from the entree.
        /// </summary>
        public void HoldCheese() {
            this.Cheese = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns the name of the entree.
        /// </summary>
        /// <returns>The name of the entree as a string.</returns>
        public override string ToString() {
            return "Veloci-Wrap";
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
                List<string> details = new List<string>(3);
                if (!this.Dressing) { details.Add("Hold Dressing"); }
                if (!this.Lettuce) { details.Add("Hold Lettuce"); }
                if (!this.Cheese) { details.Add("Hold Cheese"); }
                return details.ToArray();
            }
        }
    }
}

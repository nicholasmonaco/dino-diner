/*  SteakosaurusBurger.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu {
    /// <summary>
    /// Defines the Steakosaurus Burger entree.
    /// </summary>
    public class SteakosaurusBurger : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Indicates if the entree has a bun.
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Indicates if the entree has pickles.
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Indicates if the entree has ketchup.
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Indicates if the entree has mustard.
        /// </summary>
        public bool Mustard { get; set; } = true;


        /// <summary>
        /// Defines the ingredients that exist in the entree.
        /// </summary>
        public override List<string> Ingredients {
            get {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Pickle) ingredients.Add("Pickle");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for the Steakosaurus Burger entree.
        /// </summary>
        public SteakosaurusBurger() {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Changes the specified holdable ingredient to the specified value.
        /// </summary>
        /// <param name="index">The index of the holdable ingredient.</param>
        /// <param name="newVal">The new value of whether or not the ingredient should be held.</param>
        public override void ChangeHold(int index, bool newVal) {
            switch (index) {
                case 0:
                    Bun = newVal;
                    break;
                case 1:
                    Pickle = newVal;
                    break;
                case 2:
                    Ketchup = newVal;
                    break;
                case 3:
                    Mustard = newVal;
                    break;
            }

            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the whole wheat bun from the entree.
        /// </summary>
        public void HoldBun() {
            this.Bun = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the pickle from the entree.
        /// </summary>
        public void HoldPickle() {
            this.Pickle = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the ketchup from the entree.
        /// </summary>
        public void HoldKetchup() {
            this.Ketchup = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the mustard from the entree.
        /// </summary>
        public void HoldMustard() {
            this.Mustard = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns the name of the entree.
        /// </summary>
        /// <returns>The name of the entree as a string.</returns>
        public override string ToString() {
            return "Steakosaurus Burger";
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
                List<string> details = new List<string>(4);
                if (!this.Bun) { details.Add("Hold Bun"); }
                if (!this.Pickle) { details.Add("Hold Pickle"); }
                if (!this.Ketchup) { details.Add("Hold Ketchup"); }
                if (!this.Mustard) { details.Add("Hold Mustard"); }

                return details.ToArray();
            }
        }
    }
}

/*  Brontowurst.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu {
    /// <summary>
    /// Defines the Brontowurst entree.
    /// </summary>
    public class Brontowurst : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Indicates if the entree has a bun.
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Indicates if the entree has peppers.
        /// </summary>
        public bool Peppers { get; set; } = true;

        /// <summary>
        /// Indicates if the entree has onion.
        /// </summary>
        public bool Onion { get; set; } = true;


        /// <summary>
        /// Defines the ingredients that exist in the entree.
        /// </summary>
        public override List<string> Ingredients {
            get {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Peppers) ingredients.Add("Peppers");
                if (Onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for the Brontowurst entree.
        /// </summary>
        public Brontowurst() {
            this.Price = 5.36;
            this.Calories = 498;
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
                    Peppers = newVal;
                    break;
                case 2:
                    Onion = newVal;
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
        /// Holds the peppers from the entree.
        /// </summary>
        public void HoldPeppers() {
            this.Peppers = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the onion from the entree.
        /// </summary>
        public void HoldOnion() {
            this.Onion = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns the name of the entree.
        /// </summary>
        /// <returns>The name of the entree as a string.</returns>
        public override string ToString() {
            return "Brontowurst";
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
                if (!this.Bun) { details.Add("Hold Bun"); }
                if (!this.Peppers) { details.Add("Hold Peppers"); }
                if (!this.Onion) { details.Add("Hold Onion"); }

                return details.ToArray();
            }
        }
    }
}

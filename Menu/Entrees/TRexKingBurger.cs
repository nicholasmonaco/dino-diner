/*  TRexKingBurger.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu {
    /// <summary>
    /// Defines the T-Rex King Burger entree.
    /// </summary>
    public class TRexKingBurger : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Indicates if the entree has a bun.
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Indicates if the entree has lettuce.
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Indicates if the entree has tomato.
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Indicates if the entree has onion.
        /// </summary>
        public bool Onion { get; set; } = true;

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
        /// Indicates if the entree has mayo.
        /// </summary>
        public bool Mayo { get; set; } = true;


        /// <summary>
        /// Defines the ingredients that exist in the entree.
        /// </summary>
        public override List<string> Ingredients {
            get {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Lettuce) ingredients.Add("Lettuce");
                if (Tomato) ingredients.Add("Tomato");
                if (Onion) ingredients.Add("Onion");
                if (Pickle) ingredients.Add("Pickle");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                if (Mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor for the T-Rex King Burger entree.
        /// </summary>
        public TRexKingBurger() {
            this.Price = 8.45;
            this.Calories = 728;
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
                    Lettuce = newVal;
                    break;
                case 2:
                    Tomato = newVal;
                    break;
                case 3:
                    Onion = newVal;
                    break;
                case 4:
                    Pickle = newVal;
                    break;
                case 5:
                    Ketchup = newVal;
                    break;
                case 6:
                    Mustard = newVal;
                    break;
                case 7:
                    Mayo = newVal;
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
        /// Holds the lettuce from the entree.
        /// </summary>
        public void HoldLettuce() {
            this.Lettuce = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds the tomato from the entree.
        /// </summary>
        public void HoldTomato() {
            this.Tomato = false;
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
        /// Holds the mayo from the entree.
        /// </summary>
        public void HoldMayo() {
            this.Mayo = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns the name of the entree.
        /// </summary>
        /// <returns>The name of the entree as a string.</returns>
        public override string ToString() {
            return "T-Rex King Burger";
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
                List<string> details = new List<string>(8);
                if (!this.Bun) { details.Add("Hold Bun"); }
                if (!this.Lettuce) { details.Add("Hold Lettuce"); }
                if (!this.Tomato) { details.Add("Hold Tomato"); }
                if (!this.Onion) { details.Add("Hold Onion"); }
                if (!this.Pickle) { details.Add("Hold Pickle"); }
                if (!this.Ketchup) { details.Add("Hold Ketchup"); }
                if (!this.Mustard) { details.Add("Hold Mustard"); }
                if (!this.Mayo) { details.Add("Hold Mayo"); }

                return details.ToArray();
            }
        }
    }
}

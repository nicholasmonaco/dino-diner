/*  Entree.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu {
    /// <summary>
    /// Defines the abstract Entree object.
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Holds the price of the entree.
        /// </summary>
        private double _price;

        /// <summary>
        /// Holds the calories of the entree.
        /// </summary>
        private uint _calories;

        /// <summary>
        /// Gets and sets the price of the Entree.
        /// </summary>
        public double Price {
            get { return _price; }
            set {
                _price = value;
                NotifyOfPropertyChanged("Price");
            }
        }

        /// <summary>
        /// Gets and sets the calories.
        /// </summary>
        public uint Calories {
            get { return _calories; }
            set {
                _calories = value;
                NotifyOfPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// Gets the list of ingredients in the Entree.
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// The description of the Entree.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// A list of special instructions for food preperation.
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// Changes the specified holdable ingredient to the specified value.
        /// </summary>
        /// <param name="index">The index of the holdable ingredient.</param>
        /// <param name="newVal">The new value of whether or not the ingredient should be held.</param>
        public abstract void ChangeHold(int index, bool newVal);

        /// <summary>
        /// The event handler that handles if any properties of the entree were changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// An accessor method for invoking a property change.
        /// </summary>
        /// <param name="name">The name of the property being changed.</param>
        protected void NotifyOfPropertyChanged(string name = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

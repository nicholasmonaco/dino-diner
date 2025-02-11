﻿/*  Side.cs
*   Author: Nathan Bean
*   Modified by: Nick Monaco
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu {

    /// <summary>
    /// Defines the abstract side object.
    /// </summary>
    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Holds the price of the side.
        /// </summary>
        private double _price;

        /// <summary>
        /// Holds the calories of the side.
        /// </summary>
        private uint _calories;

        /// <summary>
        /// Gets and sets the price.
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
        /// Gets the ingredients list.
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// The description of the side.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// A list of special instructions for food preperation.
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// The event handler that handles if any properties of the side were changed.
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

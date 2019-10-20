/*  Drink.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu {

    /// <summary>
    /// Defines the abstract drink object.
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Holds the value determining if the drink contains ice or not.
        /// </summary>
        private bool _ice;

        /// <summary>
        /// Gets and sets the price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list.
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets and sets the size.
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Gets and sets if the drink contains ice.
        /// </summary>
        public bool Ice {
            get { return _ice; }
            set {
                _ice = value;
                NotifyOfPropertyChanged("Ice");
                NotifyOfPropertyChanged("Special");
            }
        }


        /// <summary>
        /// Contructor for a generic Drink object.
        /// Sets Ice to true and Size to small by default.
        /// Only usable by subclasses.
        /// </summary>
        protected Drink() {
            Ice = true;
            Size = Size.Small;
        }

        /// <summary>
        /// Sets the Ice property to false.
        /// </summary>
        public void HoldIce() {
            Ice = false;
        }

        /// <summary>
        /// The description of the drink.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// A list of special instructions for drink preperation.
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// The event handler that handles if any properties of the drink were changed.
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

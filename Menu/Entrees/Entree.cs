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
        /// Gets and sets the price of the Entree.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories of the Entree.
        /// </summary>
        public uint Calories { get; set; }

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

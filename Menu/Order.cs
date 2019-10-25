/*  Order.cs
*   Author: Nick Monaco
*/
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace DinoDiner.Menu {

    /// <summary>
    /// Defines a single order at the Dino Diner.
    /// </summary>
    public class Order : INotifyPropertyChanged{

        /// <summary>
        /// An ObservableCollection of all items on the current order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }

        /// <summary>
        /// Gets the total price by summing the price of all order items.
        /// Can never return a negative value.
        /// </summary>
        public double SubtotalCost {
            get {
                double cost = 0;
                foreach(IOrderItem i in Items) {
                    cost += i.Price;
                }
                return Math.Max(0, cost);
            }
        }

        /// <summary>
        /// Gets the current sales tax rate.
        /// Has a protected setter.
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        /// <summary>
        /// Gets the sales tax cost of the order, which is found by multiplying SalesTaxRate 
        /// and SubtotalCost together.
        /// </summary>
        public double SalesTaxCost {
            get { return SalesTaxRate * SubtotalCost; }
        }

        /// <summary>
        /// Gets the total cost of the order, which is found by adding SubtotalCost 
        /// and SalesTaxCost together.
        /// </summary>
        public double TotalCost {
            get { return SubtotalCost + SalesTaxCost; }
        }


        /// <summary>
        /// Constructor for an order.
        /// </summary>
        public Order() {
            Items = new ObservableCollection<IOrderItem>();
            this.Items.CollectionChanged += this.OnCollectionChanged;
            SalesTaxRate = 0.15; //15% sales tax
        }

        /// <summary>
        /// Notifies that certain properties will be updated when the colletion changes.
        /// </summary>
        /// <param name="sender">A sender variable.</param>
        /// <param name="e">The arguments for this operation.</param>
        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost")); // These are commented out because they don't appear anywhere
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        /// <summary>
        /// The event handler that handles if any properties of the side were changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

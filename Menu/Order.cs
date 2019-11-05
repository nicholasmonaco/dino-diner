/*  Order.cs
*   Author: Nick Monaco
*/
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;

namespace DinoDiner.Menu {

    /// <summary>
    /// Defines a single order at the Dino Diner.
    /// </summary>
    public class Order : INotifyPropertyChanged{

        /// <summary>
        /// The private backing variable for Items.
        /// NOTE: Currently unused, as Items doesn't use a backing variable.
        /// </summary>
        private ObservableCollection<IOrderItem> _items;


        /// <summary>
        /// An array of all items on the current order.
        /// </summary>
        /*public IOrderItem[] Items {
            get {
                IOrderItem[] temp = new IOrderItem[_items.Count];
                for(int i = 0; i < _items.Count; i++) {
                    temp[i] = _items[i];
                }
                return temp;
            }
        }*/

        /// <summary>
        /// An ObservableCollection of all items on the current order.
        /// NOTE: This is not the array implementation (above), as having the array implementation breaks the OrderUI.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; }

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
            _items = new ObservableCollection<IOrderItem>();
            this._items.CollectionChanged += this.OnCollectionChanged;

            Items = new ObservableCollection<IOrderItem>();
            this.Items.CollectionChanged += this.OnCollectionChanged;

            SalesTaxRate = 0.15; //15% sales tax
        }

        /// <summary>
        /// Adds the passed in item to the list of items
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void Add(IOrderItem item) {
            item.PropertyChanged += UpdateItemsProperty;
            _items.Add(item);

            Items.Add(item);

            NotifyOfPropertyChanged("Items");
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
        }

        /// <summary>
        /// Removes the passed in item from the list of items
        /// </summary>
        /// <param name="item">The item to remove.</param>
        public void Remove(IOrderItem item) {
            _items.Remove(item);

            Items.Remove(item);

            NotifyOfPropertyChanged("Items");
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
        }

        /// <summary>
        /// Clears the order of all items.
        /// </summary>
        public void Clear() {
            _items.Clear();

            Items.Clear();

            NotifyOfPropertyChanged("Items");
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
        }


        /// <summary>
        /// Notifies that certain properties will be updated when the colletion changes.
        /// </summary>
        /// <param name="sender">A sender variable.</param>
        /// <param name="e">The arguments for this operation.</param>
        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
            NotifyOfPropertyChanged("Items");
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");

        }

        /// <summary>
        /// Notifies that relevant fields change when the order is changed.
        /// </summary>
        public void UpdateItemsProperty(object sender, PropertyChangedEventArgs e) {
            NotifyOfPropertyChanged("Items");
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
        }


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

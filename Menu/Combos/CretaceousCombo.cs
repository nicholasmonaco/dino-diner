/*  CretaceousCombo.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu {

    /// <summary>
    /// Defines the Cretaceous Combo object.
    /// </summary>
    public class CretaceousCombo : IMenuItem, IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Holds the current entree of the combo.
        /// </summary>
        private Entree _entree = new SteakosaurusBurger();

        /// <summary>
        /// Holds the current side of the combo.
        /// </summary>
        private Side _side = new Fryceritops();

        /// <summary>
        /// Holds the current drink of the combo.
        /// </summary>
        private Drink _drink = new Sodasaurus();

        /// <summary>
        /// Holds the current toy of the combo.
        /// </summary>
        private string _toy;

        /// <summary>
        /// Holds the current Size of the combo.
        /// </summary>
        private Size _size;


        /// <summary>
        /// Gets and sets the entree.
        /// </summary>
        public Entree Entree {
            get { return _entree; }
            set {
                _entree = value;
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Entree");
            }
        }

        /// <summary>
        /// Gets and sets the side.
        /// </summary>
        public Side Side {
            get { return _side; }
            set {
                _side = value;
                this._side.PropertyChanged += ItemChangeNotify;
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Side");
            }
        }

        /// <summary>
        /// Gets and sets the drink.
        /// </summary>
        public Drink Drink {
            get { return _drink; }
            set {
                _drink = value;
                this._drink.PropertyChanged += ItemChangeNotify;
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Drink");
            }
        }

        /// <summary>
        /// Gets the toy.
        /// Has a private setter.
        /// </summary>
        public string Toy {
            get { return _toy; }
            private set {
                _toy = value;
                NotifyOfPropertyChanged("Toy");
            }
        }

        /// <summary>
        /// The total price of the combo.
        /// Getting a combo saves the customer 25 cents.
        /// </summary>
        public double Price {
            get {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// The sum of the calories of all items in the combo.
        /// </summary>
        public uint Calories {
            get {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// The ingredients of all items in the combo.
        /// </summary>
        public List<string> Ingredients {
            get {
                List<string> i = new List<string>();
                i.AddRange(Entree.Ingredients);
                i.AddRange(Side.Ingredients);
                i.AddRange(Drink.Ingredients);
                return i;
            }
        }


        /// <summary>
        /// Constructs a new CretaceousCombo with the specified entree.
        /// </summary>
        /// <param name="e">The entree in the combo.</param>
        public CretaceousCombo(Entree e) {
            this.Entree = e;
            this.Toy = "Random Toy";

            this._side.PropertyChanged += ItemChangeNotify;
            this._drink.PropertyChanged += ItemChangeNotify;
        }

        /// <summary>
        /// Changes the current toy to the specified toy.
        /// </summary>
        /// <param name="newToyName"></param>
        public void ChangeToy(string newToyName) {
            this.Toy = newToyName;
        }

        /// <summary>
        /// Returns the name of the combo, using the selected entree as a base.
        /// </summary>
        /// <returns>Returns the name of the combo.</returns>
        public override string ToString() {
            return $"{this.Entree} Combo";
        }

        /// <summary>
        /// Gets the description of the combo.
        /// </summary>
        public string Description {
            get { return this.ToString(); }
        }

        /// <summary>
        /// A list of special instructions to be used during combo preparation.
        /// </summary>
        public string[] Special {
            get {
                List<string> details = new List<string>();
                details.AddRange(this.Entree.Special);
                details.Add(this.Side.Description);
                details.AddRange(this.Side.Special);
                details.Add(this.Drink.Description);
                details.AddRange(this.Drink.Special);

                return details.ToArray();
            }
        }

        /// <summary>
        /// Gets and sets the size of the combo, which trickles down into it's components.
        /// The setter also adjusts the price and calories of the combo accordingly.
        /// </summary>
        public Size Size {
            get {
                return _size;
            }
            set {
                _drink.Size = value;
                _side.Size = value;

                NotifyOfPropertyChanged("Size");
            }
        }


        /// <summary>
        /// Notifies of updates of the relevant properties when properties of and item is changed.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The PropertyChangedEvetArgs.</param>
        private void ItemChangeNotify(object sender, PropertyChangedEventArgs e) {
            NotifyOfPropertyChanged("Description");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
        }


        /// <summary>
        /// The event handler that handles if any properties of the combo were changed.
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

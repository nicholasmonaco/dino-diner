/*  CretaceousCombo.cs
*   Author: Nick Monaco
*/

using System.Collections.Generic;

namespace DinoDiner.Menu {

    /// <summary>
    /// Defines the Cretaceous Combo object.
    /// </summary>
    public class CretaceousCombo : IMenuItem {

        /// <summary>
        /// Gets and sets the entree.
        /// </summary>
        public Entree Entree { get; set; } = new SteakosaurusBurger();

        /// <summary>
        /// Gets and sets the side.
        /// </summary>
        public Side Side { get; set; } = new Fryceritops();

        /// <summary>
        /// Gets and sets the drink.
        /// </summary>
        public Drink Drink { get; set; } = new Sodasaurus();

        /// <summary>
        /// Gets the toy.
        /// </summary>
        public string Toy { get; private set; }

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
        }


        /// <summary>
        /// Returns the name of the combo, using the selected entree as a base.
        /// </summary>
        /// <returns>Returns the name of the combo.</returns>
        public override string ToString() {
            return $"{this.Entree} Combo";
        }

    }
}

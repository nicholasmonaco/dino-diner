/*  Menu.cs
*   Author: Nick Monaco
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu {

    /// <summary>
    /// Defines the menu of the Dino Diner.
    /// </summary>
    public class Menu {

        /// <summary>
        /// A list of all available menu items.
        /// </summary>
        public List<IMenuItem> AvailableMenuItems {
            get {
                List<IMenuItem> i = new List<IMenuItem>(AvailableEntrees);
                i.AddRange(AvailableSides);
                i.AddRange(AvailableDrinks);
                i.AddRange(AvailableCombos);

                return i;
            }
        }

        /// <summary>
        /// A list of all available entrees.
        /// </summary>
        public List<Entree> AvailableEntrees {
            get {
                return new List<Entree>() {
                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new PterodactylWings(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap()
                };
            }
        }

        /// <summary>
        /// A list of all available sides.
        /// </summary>
        public List<Side> AvailableSides {
            get {
                return new List<Side>() {
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()
                };
            }
        }

        /// <summary>
        /// A list of all available drinks.
        /// </summary>
        public List<Drink> AvailableDrinks {
            get {
                return new List<Drink>() {
                    new JurassicJava(),
                    new Sodasaurus(),
                    new Tyrannotea(),
                    new Water()
                };
            }
        }

        /// <summary>
        /// A list of all available combos.
        /// </summary>
        public List<CretaceousCombo> AvailableCombos {
            get {
                List<CretaceousCombo> combos = new List<CretaceousCombo>(AvailableEntrees.Count);
                for(int i = 0; i < AvailableEntrees.Count; i++) {
                    combos.Add(new CretaceousCombo(AvailableEntrees[i]));
                }

                return combos;
            }
        }

        /// <summary>
        /// Returns all menu items on different lines, formatted as a single string.
        /// </summary>
        /// <returns>A string containing each menu item on a separate line.</returns>
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < AvailableMenuItems.Count; i++) {
                sb.Append(AvailableMenuItems[i].ToString());
                sb.Append("\n");
            }

            return sb.ToString();
        }

    }
}

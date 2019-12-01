/*  Menu.cs
*   Author: Nick Monaco
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

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

        public HashSet<string> PossibleIngredients {
            get {
                HashSet<string> ings = new HashSet<string>();

                // No combo iterator since combos are composed of entrees, drinks, and sides

                foreach(Entree e in AvailableEntrees) {
                    ings.UnionWith(e.Ingredients);
                }

                foreach (Side s in AvailableSides) {
                    ings.UnionWith(s.Ingredients);
                }

                foreach (Drink d in AvailableDrinks) {
                    ings.UnionWith(d.Ingredients);
                }

                return ings;
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

        public List<IMenuItem>[] FilterByCategory(List<IMenuItem>[] items, List<string> filters) {
            List<IMenuItem>[] results = new List<IMenuItem>[4];
            for(int i = 0; i < results.Length; i++) {
                results[i] = new List<IMenuItem>();
            }

            if (filters.Contains("Combo", StringComparer.OrdinalIgnoreCase)) {
                results[0].AddRange(items[0]);
            }
            if (filters.Contains("Entree", StringComparer.OrdinalIgnoreCase)) {
                results[1].AddRange(items[1]);
            }
            if (filters.Contains("Side", StringComparer.OrdinalIgnoreCase)) {
                results[2].AddRange(items[2]);
            }
            if (filters.Contains("Drink", StringComparer.OrdinalIgnoreCase)) {
                results[3].AddRange(items[3]);
            }

            return results;
        }

        public List<IMenuItem>[] FilterByPrice(List<IMenuItem>[] items, float minPrice, float maxPrice) {
            List<IMenuItem>[] results = new List<IMenuItem>[4];
            for (int i = 0; i < results.Length; i++) {
                results[i] = new List<IMenuItem>();

                foreach (IMenuItem item in items[i]) {
                    if (item.Price <= maxPrice && item.Price >= minPrice) {
                        results[i].Add(item);
                    }
                }
            }

            return results;
        }

        public List<IMenuItem>[] FilterByIngredients(List<IMenuItem>[] items, List<string> ingBlacklist) {
            List<IMenuItem>[] results = new List<IMenuItem>[4];
            for (int i = 0; i < results.Length; i++) {
                results[i] = new List<IMenuItem>();

                foreach (IMenuItem menuItem in items[i]) {
                    if(menuItem is IOrderItem item) {
                        bool has = false;

                        foreach(string ing in ingBlacklist) {
                            if (item.Ingredients.Contains(ing, StringComparer.OrdinalIgnoreCase)) {
                                has = true;
                                break;
                            }
                        }

                        if (has == false) {
                            results[i].Add(menuItem);
                        }
                    }
                }
            }

            return results;
        }

        public List<IMenuItem>[] Search(List<IMenuItem>[] items, string search, bool searchIngredients) {
            List<IMenuItem>[] results = new List<IMenuItem>[4];
            for (int i = 0; i < results.Length; i++) {
                results[i] = new List<IMenuItem>();
            }

            foreach (IMenuItem menuItem in items[0]) {
                if (menuItem is CretaceousCombo combo) {
                    if (combo.Description.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        combo.Side.Description.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        combo.Drink.Description.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0) {

                        results[0].Add(combo);
                        continue;
                    }

                    if (searchIngredients) {
                        if (combo.Ingredients.Contains(search, StringComparer.OrdinalIgnoreCase)) {
                            results[0].Add(combo);
                        }
                    }
                }
            }

            for(int i = 1; i < items.Length; i++) {
                foreach (IMenuItem menuItem in items[i]) {
                    if (menuItem is IOrderItem item) {
                        if (item.Description.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0) {
                            results[i].Add(menuItem);
                            continue;
                        }

                        if (searchIngredients) {
                            if (item.Ingredients.Contains(search, StringComparer.OrdinalIgnoreCase)) {
                                results[i].Add(menuItem);
                            }
                        }
                    }
                }
            }

            return results;
        }


    }
}

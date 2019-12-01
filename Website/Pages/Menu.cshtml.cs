/*  Menu.cshtml.cs
*   Author: Nick Monaco
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// The Menu variable that allows an instance of a menu to be accessed in the cshtml file.
        /// </summary>
        public Menu Menu { get; private set; } = new Menu();

        public List<IMenuItem>[] Items;

        [BindProperty]
        public string search { get; set; } = null;

        [BindProperty]
        public bool SearchIngredients { get; set; } = false;

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public float? minimumPrice { get; set; } = null;

        [BindProperty]
        public float? maximumPrice { get; set; } = null;

        [BindProperty]
        public List<string> blacklistedIngredients { get; set; } = new List<string>();



        /// <summary>
        /// The OnGet function, which starts the page by adding all possible menu items to Items.
        /// </summary>
        public void OnGet()
        {
            InitItems();
        }

        /// <summary>
        /// The OnPost function, which handles what happens when the "Search and Filter" button is clicked.
        /// </summary>
        public void OnPost() {
            InitItems();

            if(menuCategory.Count > 0) {
                Items = Menu.FilterByCategory(Items, menuCategory);
            }

            if (minimumPrice is float min && maximumPrice is float max) {
                Items = Menu.FilterByPrice(Items, min, max);
            } else if (minimumPrice is float min1) {
                Items = Menu.FilterByPrice(Items, min1, float.MaxValue);
            } else if (maximumPrice is float max1) {
                Items = Menu.FilterByPrice(Items, float.MinValue, max1);
            }


            if (search != null) {
                Items = Menu.Search(Items, search, SearchIngredients);
            }

        }

        private void InitItems() {
            Items = new List<IMenuItem>[4];

            Items[0] = new List<IMenuItem>();
            Items[0].AddRange(Menu.AvailableCombos);

            Items[1] = new List<IMenuItem>();
            Items[1].AddRange(Menu.AvailableEntrees);

            Items[2] = new List<IMenuItem>();
            Items[2].AddRange(Menu.AvailableSides);

            Items[3] = new List<IMenuItem>();
            Items[3].AddRange(Menu.AvailableDrinks);
        }

        public bool ItemsEmpty {
            get {
                if(Items[0].Count == 0 &&
                    Items[1].Count == 0 &&
                    Items[2].Count == 0 &&
                    Items[3].Count == 0) {
                    return true;
                }
                return false;
            }
        }

    }
}
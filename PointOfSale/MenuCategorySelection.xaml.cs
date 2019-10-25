/*  MenuCategorySelection.cs
*   Author: Nick Monaco
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page {

        /// <summary>
        /// Constructs the MenuCategorySelection page.
        /// </summary>
        public MenuCategorySelection() {
            InitializeComponent();
            this.ShowsNavigationUI = false;
        }

        /// <summary>
        /// Handles what happens when the Combos button is clicked.
        /// In this case, navigates to the combo selection page.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="args">The RoutedEventArgs.</param>
        public void SelectCombos(object sender, RoutedEventArgs args) {
            NavigationService.Navigate(new ComboSelection());
        }

        /// <summary>
        /// Handles what happens when the Drinks button is clicked.
        /// In this case, navigates to the drink selection page.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="args">The RoutedEventArgs.</param>
        private void SelectDrinks(object sender, RoutedEventArgs e) {
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Handles what happens when the Entrees button is clicked.
        /// In this case, navigates to the entree selection page.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="args">The RoutedEventArgs.</param>
        private void SelectEntrees(object sender, RoutedEventArgs e) {
            NavigationService.Navigate(new EntreeSelection());
        }

        /// <summary>
        /// Handles what happens when the Sides button is clicked.
        /// In this case, navigates to the side selection page.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="args">The RoutedEventArgs.</param>
        private void SelectSides(object sender, RoutedEventArgs e) {
            NavigationService.Navigate(new SideSelection());
        }
    }
}

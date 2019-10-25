/*  FlavorSelection.cs
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
using DinoDiner.Menu;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page {

        /// <summary>
        /// Gets and sets the page to return to once a flavor is selected.
        /// </summary>
        public DrinkSelection returnPage { get; set; }

        /// <summary>
        /// The value of the selected flavor.
        /// The setter is marked private.
        /// </summary>
        public SodasaurusFlavor flavor { get; private set; }


        /// <summary>
        /// Constructs the FlavorSelection page.
        /// </summary>
        public FlavorSelection() {
            InitializeComponent();
            this.ShowsNavigationUI = false;

            flavor = SodasaurusFlavor.Cola;
        }

        /// <summary>
        /// Handles what happens when any flavor button is clicked
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="args">The RoutedEventArgs.</param>
        private void FlavorClick(object sender, RoutedEventArgs args) {
            string pickedFlavor = (string)(((Button)sender).Content);

            switch (pickedFlavor) {
                case "Cherry":
                    flavor = SodasaurusFlavor.Cherry;
                    break;
                case "Chocolate":
                    flavor = SodasaurusFlavor.Chocolate;
                    break;
                case "Cola":
                    flavor = SodasaurusFlavor.Cola;
                    break;
                case "Lime":
                    flavor = SodasaurusFlavor.Lime;
                    break;
                case "Orange":
                    flavor = SodasaurusFlavor.Orange;
                    break;
                case "Root Beer":
                    flavor = SodasaurusFlavor.RootBeer;
                    break;
                case "Vanilla":
                    flavor = SodasaurusFlavor.Vanilla;
                    break;
            }
            returnPage.ChangeFlavor(flavor);
            NavigationService.Navigate(returnPage);
        }
    }
}

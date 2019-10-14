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
        /// The ID value of the selected flavor.
        /// The setter is marked private.
        /// </summary>
        public int flavorID { get; private set; }


        /// <summary>
        /// Constructs the FlavorSelection page.
        /// </summary>
        public FlavorSelection() {
            InitializeComponent();
            flavorID = -1;
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
                    flavorID = 0;
                    break;
                case "Chocolate":
                    flavorID = 1;
                    break;
                case "Cola":
                    flavorID = 2;
                    break;
                case "Lime":
                    flavorID = 3;
                    break;
                case "Orange":
                    flavorID = 4;
                    break;
                case "Root Beer":
                    flavorID = 5;
                    break;
                case "Vanilla":
                    flavorID = 6;
                    break;
            }
            returnPage.ChangeFlavor(flavorID);
            NavigationService.Navigate(returnPage);
        }
    }
}

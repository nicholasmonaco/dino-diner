/*  EntreeSelection.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page {

        /// <summary>
        /// Constructs the EntreeSelection page.
        /// </summary>
        public EntreeSelection() {
            InitializeComponent();
        }

        /// <summary>
        /// Handles what happens when an entree button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="args">The RoutedEventArgs.</param>
        private void EntreeClick(object sender, RoutedEventArgs args) {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}

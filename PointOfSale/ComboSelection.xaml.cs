/*  ComboSelection.cs
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page {

        /// <summary>
        /// Constructs the ComboSelection page.
        /// </summary>
        public ComboSelection() {
            InitializeComponent();
            this.ShowsNavigationUI = false;
        }

        /// <summary>
        /// Handles what happens when a combo button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="args">The RoutedEventArgs.</param>
        private void ComboClick(object sender, RoutedEventArgs e) {
            NavigationService.Navigate(new CustomizeCombo());
        }
    }
}

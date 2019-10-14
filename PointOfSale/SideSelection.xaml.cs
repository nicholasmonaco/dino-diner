/*  SideSelection.cs
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page {

        /// <summary>
        /// Gets and sets the size of the side.
        /// The setter is marked private.
        /// </summary>
        public int Size { get; private set; }


        /// <summary>
        /// Constructs the SideSelection page.
        /// </summary>
        public SideSelection() {
            InitializeComponent();

            uxFryceritops.Background = Brushes.LightBlue;
            uxMeteorMac.Background = Brushes.White;
            uxMezzorellaSticks.Background = Brushes.White;
            uxTriceritots.Background = Brushes.White;

            uxSmallBox.Background = Brushes.White;
            uxMediumBox.Background = Brushes.LightBlue;
            uxLargeBox.Background = Brushes.White;
        }

        /// <summary>
        /// Handles what happens when the Small size button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void SmallClicked(object sender, RoutedEventArgs e) {
            uxSmallBox.Background = Brushes.LightBlue;
            uxMediumBox.Background = Brushes.White;
            uxLargeBox.Background = Brushes.White;
            Size = 0;
        }

        /// <summary>
        /// Handles what happens when the Medium size button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void MediumClicked(object sender, RoutedEventArgs e) {
            uxSmallBox.Background = Brushes.White;
            uxMediumBox.Background = Brushes.LightBlue;
            uxLargeBox.Background = Brushes.White;
            Size = 1;
        }

        /// <summary>
        /// Handles what happens when the Large size button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void LargeClicked(object sender, RoutedEventArgs e) {
            uxSmallBox.Background = Brushes.White;
            uxMediumBox.Background = Brushes.White;
            uxLargeBox.Background = Brushes.LightBlue;
            Size = 2;
        }


        /// <summary>
        /// Handles what happens when the Fryceritops button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void FryClick(object sender, RoutedEventArgs e) {
            uxFryceritops.Background = Brushes.LightBlue;
            uxMeteorMac.Background = Brushes.White;
            uxMezzorellaSticks.Background = Brushes.White;
            uxTriceritots.Background = Brushes.White;
        }

        /// <summary>
        /// Handles what happens when the Meteor Mac & Cheese button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void MacClick(object sender, RoutedEventArgs e) {
            uxFryceritops.Background = Brushes.White;
            uxMeteorMac.Background = Brushes.LightBlue;
            uxMezzorellaSticks.Background = Brushes.White;
            uxTriceritots.Background = Brushes.White;
        }

        /// <summary>
        /// Handles what happens when the Mezzorella Sticks button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void StickClick(object sender, RoutedEventArgs e) {
            uxFryceritops.Background = Brushes.White;
            uxMeteorMac.Background = Brushes.White;
            uxMezzorellaSticks.Background = Brushes.LightBlue;
            uxTriceritots.Background = Brushes.White;
        }

        /// <summary>
        /// Handles what happens when the Triceritots button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void TotClick(object sender, RoutedEventArgs e) {
            uxFryceritops.Background = Brushes.White;
            uxMeteorMac.Background = Brushes.White;
            uxMezzorellaSticks.Background = Brushes.White;
            uxTriceritots.Background = Brushes.LightBlue;
        }
    }
}

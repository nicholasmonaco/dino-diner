/*  DrinkSelection.cs
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
using System.ComponentModel;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page {

        /// <summary>
        /// An enum that contains the 4 types of drinks.
        /// </summary>
        public enum Drinks { Sodasaurus, Tyrannotea, JurassicJava, Water }

        /// <summary>
        /// Gets and sets the size of the drink.
        /// The setter is marked private.
        /// </summary>
        public int Size { get; private set; }

        /// <summary>
        /// The currently selected drink, represented with the Drinks enum.
        /// The setter is marked private.
        /// </summary>
        public Drinks CurDrink { get; private set; }

        /// <summary>
        /// A string array containing all 7 possible Sodasaurus flavors.
        /// </summary>
        private string[] flavors = new string[] { "Cherry", "Chocolate", "Cola", "Lime", "Orange", "Root Beer", "Vanilla" };

        /// <summary>
        /// Gets and sets if uxExtraData is pressed or not.
        /// The setter is marked private.
        /// </summary>
        public bool SpecialValue { get; private set; }

        /// <summary>
        /// Gets and sets the ID of the currenly selected Sodasaurus flavor.
        /// </summary>
        public int SpecialFlavor { get; set; }

        /// <summary>
        /// Gets and sets if uxLemon is pressed or not.
        /// The setter is marked private.
        /// </summary>
        public bool LemonValue { get; private set; }

        /// <summary>
        /// Gets and sets if uxIce is pressed or not.
        /// The setter is marked private.
        /// </summary>
        public bool HasIce { get; private set; }


        /// <summary>
        /// Constructs the DrinkSelection page.
        /// A cherry Sodasaurus drink is the default.
        /// </summary>
        public DrinkSelection() {
            InitializeComponent();
            this.DataContext = this;

            uxSmallBox.Background = Brushes.White;
            uxMediumBox.Background = Brushes.LightBlue;
            uxLargeBox.Background = Brushes.White;
            Size = 1;

            uxSodasaurus.Background = Brushes.LightBlue;
            uxTyrannotea.Background = Brushes.White;
            uxJurassicJava.Background = Brushes.White;
            uxWater.Background = Brushes.White;
            CurDrink = Drinks.Sodasaurus;
            SpecialFlavor = 0;
            uxExtraData.Content = flavors[0];
            HasIce = true;
            uxIce.Content = "Remove Ice";

            uxLemon.Visibility = Visibility.Collapsed;
            uxIce.Background = Brushes.LightBlue;
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
        /// Handles what happens when the Sodasaurus button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void SodaClick(object sender, RoutedEventArgs e) {
            uxSodasaurus.Background = Brushes.LightBlue;
            uxTyrannotea.Background = Brushes.White;
            uxJurassicJava.Background = Brushes.White;
            uxWater.Background = Brushes.White;
            CurDrink = Drinks.Sodasaurus;

            uxExtraData.Visibility = Visibility.Visible;
            uxExtraData.Background = SystemColors.ControlBrush;
            uxExtraData.Content = "Change Flavor";
            SpecialFlavor = 0;
            uxLemon.Visibility = Visibility.Collapsed;
            HasIce = true;
            uxIce.Background = Brushes.LightBlue;
        }

        /// <summary>
        /// Handles what happens when the Tyrannotea button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void TeaClick(object sender, RoutedEventArgs e) {
            uxSodasaurus.Background = Brushes.White;
            uxTyrannotea.Background = Brushes.LightBlue;
            uxJurassicJava.Background = Brushes.White;
            uxWater.Background = Brushes.White;
            CurDrink = Drinks.Tyrannotea;

            uxExtraData.Visibility = Visibility.Visible;
            uxExtraData.Background = Brushes.White;
            uxExtraData.Content = "Make Sweet";
            SpecialValue = false;
            uxLemon.Visibility = Visibility.Visible;
            uxLemon.Background = Brushes.White;
            uxLemon.Content = "Add Lemon";
            LemonValue = false;
            uxIce.Background = Brushes.LightBlue;
            HasIce = true;
        }

        /// <summary>
        /// Handles what happens when the Jurassic Java button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void JavaClick(object sender, RoutedEventArgs e) {
            uxSodasaurus.Background = Brushes.White;
            uxTyrannotea.Background = Brushes.White;
            uxJurassicJava.Background = Brushes.LightBlue;
            uxWater.Background = Brushes.White;
            CurDrink = Drinks.JurassicJava;

            uxExtraData.Visibility = Visibility.Visible;
            uxExtraData.Background = Brushes.White;
            uxExtraData.Content = "Make Decaf";
            SpecialValue = false;
            uxLemon.Visibility = Visibility.Collapsed;
            uxIce.Background = Brushes.LightBlue;
            HasIce = false;
        }

        /// <summary>
        /// Handles what happens when the Water button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void WaterClick(object sender, RoutedEventArgs e) {
            uxSodasaurus.Background = Brushes.White;
            uxTyrannotea.Background = Brushes.White;
            uxJurassicJava.Background = Brushes.White;
            uxWater.Background = Brushes.LightBlue;
            CurDrink = Drinks.Water;

            uxExtraData.Visibility = Visibility.Collapsed;
            uxLemon.Visibility = Visibility.Visible;
            uxLargeBox.Background = Brushes.White;
            uxLemon.Content = "Add Lemon";
            LemonValue = false;
            uxIce.Background = Brushes.LightBlue;
            HasIce = true;
        }

        /// <summary>
        /// Handles what happens when the special data button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void SpecialClick(object sender, RoutedEventArgs e) {
            switch (CurDrink) {
                case Drinks.Sodasaurus:
                    FlavorSelection flavorPage = new FlavorSelection();
                    flavorPage.returnPage = this;
                    NavigationService.Navigate(flavorPage);
                    break;
                case Drinks.Tyrannotea:
                    if (!SpecialValue) {
                        uxExtraData.Content = "Make Unsweet";
                        SpecialValue = true;
                        uxExtraData.Background = Brushes.LightBlue;
                    } else {
                        uxExtraData.Content = "Make Sweet";
                        SpecialValue = false;
                        uxExtraData.Background = Brushes.White;
                    }
                    break;
                case Drinks.JurassicJava:
                    if (!SpecialValue) {
                        uxExtraData.Content = "Make Caffeinated";
                        SpecialValue = true;
                        uxExtraData.Background = Brushes.LightBlue;
                    } else {
                        uxExtraData.Content = "Make Decaf";
                        SpecialValue = false;
                        uxExtraData.Background = Brushes.White;
                    }
                    break;
            }
        }

        /// <summary>
        /// Handles what happens when the Lemon button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void LemonClick(object sender, RoutedEventArgs e) {
            if (!LemonValue) {
                uxLemon.Content = "Remove Lemon";
                LemonValue = true;
                uxLemon.Background = Brushes.LightBlue;
            }else {
                uxLemon.Content = "Add Lemon";
                LemonValue = false;
                uxLemon.Background = Brushes.White;
            }
        }

        /// <summary>
        /// Handles what happens when the Ice button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void IceClick(object sender, RoutedEventArgs e) {
            if (!HasIce) {
                uxIce.Content = "Remove Ice";
                HasIce = true;
                uxIce.Background = Brushes.LightBlue;
            } else {
                uxIce.Content = "Add Ice";
                HasIce = false;
                uxIce.Background = Brushes.White;
            }
        }

        /// <summary>
        /// Changes the current flavor.
        /// Used from the FlavorSelection page to get the changed flavor in the previous page.
        /// </summary>
        /// <param name="newFlavorID"></param>
        public void ChangeFlavor(int newFlavorID) {
            this.SpecialFlavor = newFlavorID;
            uxExtraData.Content = flavors[newFlavorID];
        }
    }
}

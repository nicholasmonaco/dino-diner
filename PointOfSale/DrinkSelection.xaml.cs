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
using DinoDiner.Menu;

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
        public DinoDiner.Menu.Size Size { get; private set; }

        /// <summary>
        /// The currently selected drink, represented with the Drinks enum.
        /// The setter is marked private.
        /// </summary>
        public Drinks CurDrink { get; private set; }

        /// <summary>
        /// Gets and sets if uxExtraData is pressed or not.
        /// The setter is marked private.
        /// </summary>
        public bool SpecialValue { get; private set; }

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
            this.ShowsNavigationUI = false;

            this.DataContext = this;

            uxSmallBox.Background = Brushes.White;
            uxMediumBox.Background = Brushes.White;
            uxLargeBox.Background = Brushes.White;
            Size = DinoDiner.Menu.Size.Small;

            uxSodasaurus.Background = Brushes.White;
            uxTyrannotea.Background = Brushes.White;
            uxJurassicJava.Background = Brushes.White;
            uxWater.Background = Brushes.White;
            CurDrink = Drinks.Sodasaurus;
            uxExtraData.Content = SodasaurusFlavor.Cola;
            HasIce = true;
            uxIce.Content = "Remove Ice";

            uxLemon.Visibility = Visibility.Collapsed;
            uxIce.Visibility = Visibility.Collapsed;
            uxExtraData.Visibility = Visibility.Collapsed;
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
            Size = DinoDiner.Menu.Size.Small;

            if (DataContext is Order order) {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink) {
                    drink.Size = DinoDiner.Menu.Size.Small;
                }
            }
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
            Size = DinoDiner.Menu.Size.Medium;

            if (DataContext is Order order) {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink) {
                    drink.Size = DinoDiner.Menu.Size.Medium;
                }
            }
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
            Size = DinoDiner.Menu.Size.Large;

            if (DataContext is Order order) {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink) {
                    drink.Size = DinoDiner.Menu.Size.Large;
                }
            }
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
            uxExtraData.Content = "Cola";
            uxLemon.Visibility = Visibility.Collapsed;
            HasIce = true;
            uxIce.Background = Brushes.LightBlue;
            uxIce.Visibility = Visibility.Visible;

            AddItem(new Sodasaurus());
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
            uxIce.Visibility = Visibility.Visible;

            AddItem(new Tyrannotea());
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
            uxIce.Visibility = Visibility.Visible;

            AddItem(new JurassicJava());
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
            uxIce.Visibility = Visibility.Visible;

            AddItem(new Water());
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

                    if (DataContext is Order order1) {
                        if (CollectionViewSource.GetDefaultView(order1.Items).CurrentItem is Tyrannotea tea) {
                            tea.Sweet = SpecialValue;
                        }
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

                    if (DataContext is Order order2) {
                        if (CollectionViewSource.GetDefaultView(order2.Items).CurrentItem is JurassicJava java) {
                            java.Decaf = SpecialValue;
                        }
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

            if (DataContext is Order order) {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink) {
                    if(drink is Tyrannotea tea) {
                        tea.Lemon = LemonValue;
                    }else if(drink is Water water) {
                        water.Lemon = LemonValue;
                    }
                }
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

            if (DataContext is Order order) {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink) {
                    drink.Ice = HasIce;
                }
            }
        }

        /// <summary>
        /// Handles what happens when the Done button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void DoneClick(object sender, RoutedEventArgs e) {
            NavigationService.Navigate(new MenuCategorySelection());
        }


        /// <summary>
        /// Changes the current flavor.
        /// Used from the FlavorSelection page to get the changed flavor in the previous page.
        /// </summary>
        /// <param name="newFlavorID"></param>
        public void ChangeFlavor(SodasaurusFlavor newFlavor) {
            if(newFlavor == SodasaurusFlavor.RootBeer) {
                uxExtraData.Content = "Root Beer";
            } else {
                uxExtraData.Content = newFlavor;
            }

            if (DataContext is Order order) {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda) {
                    soda.Flavor = newFlavor;
                }
            }
        }

        /// <summary>
        /// Handles what happens on the page when the selected item in the order is changed.
        /// </summary>
        public void UpdateButtons() {
            uxSodasaurus.Background = Brushes.White;
            uxTyrannotea.Background = Brushes.White;
            uxJurassicJava.Background = Brushes.White;
            uxWater.Background = Brushes.White;

            uxSmallBox.Background = Brushes.White;
            uxMediumBox.Background = Brushes.White;
            uxLargeBox.Background = Brushes.White;


            if (DataContext is Order order) {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink) {
                    Size = drink.Size;
                    switch (Size) {
                        case DinoDiner.Menu.Size.Small:
                            uxSmallBox.Background = Brushes.LightBlue;
                            break;
                        case DinoDiner.Menu.Size.Medium:
                            uxMediumBox.Background = Brushes.LightBlue;
                            break;
                        case DinoDiner.Menu.Size.Large:
                            uxLargeBox.Background = Brushes.LightBlue;
                            break;
                    }

                    if (drink is Sodasaurus soda) {
                        uxSodasaurus.Background = Brushes.LightBlue;
                        CurDrink = Drinks.Sodasaurus;
                        uxExtraData.Visibility = Visibility.Visible;
                        uxExtraData.Background = SystemColors.ControlBrush;
                        if(soda.Flavor == SodasaurusFlavor.RootBeer) {
                            uxExtraData.Content = "Root Beer";
                        } else {
                            uxExtraData.Content = soda.Flavor;
                        }
                        uxLemon.Visibility = Visibility.Collapsed;
                        uxIce.Visibility = Visibility.Visible;

                    } else if (drink is Tyrannotea tea) {
                        uxTyrannotea.Background = Brushes.LightBlue;
                        CurDrink = Drinks.Tyrannotea;
                        uxExtraData.Visibility = Visibility.Visible;
                        if (tea.Sweet) {
                            uxExtraData.Background = Brushes.LightBlue;
                            uxExtraData.Content = "Make Unsweet";
                        } else {
                            uxExtraData.Background = Brushes.White;
                            uxExtraData.Content = "Make Sweet";
                        }
                        SpecialValue = tea.Sweet;

                        uxLemon.Visibility = Visibility.Visible;
                        if (tea.Lemon) {
                            uxLemon.Background = Brushes.LightBlue;
                            uxLemon.Content = "Remove Lemon";
                        } else {
                            uxLemon.Background = Brushes.White;
                            uxLemon.Content = "Add Lemon";
                        }
                        LemonValue = tea.Lemon;

                    } else if (drink is JurassicJava java) {
                        uxJurassicJava.Background = Brushes.LightBlue;
                        CurDrink = Drinks.JurassicJava;
                        uxExtraData.Visibility = Visibility.Visible;
                        if (java.Decaf) {
                            uxExtraData.Background = Brushes.LightBlue;
                            uxExtraData.Content = "Make Caffeinated";
                        } else {
                            uxExtraData.Background = Brushes.White;
                            uxExtraData.Content = "Make Decaf";
                        }
                        SpecialValue = java.Decaf;
                        uxLemon.Visibility = Visibility.Collapsed;

                    } else if (drink is Water water) {
                        uxWater.Background = Brushes.LightBlue;
                        CurDrink = Drinks.Water;
                        uxExtraData.Visibility = Visibility.Collapsed;
                        uxLemon.Visibility = Visibility.Visible;
                        if (water.Lemon) {
                            uxLargeBox.Background = Brushes.LightBlue;
                            uxLemon.Content = "Remove Lemon";
                        } else {
                            uxLargeBox.Background = Brushes.White;
                            uxLemon.Content = "Add Lemon";
                        }
                        LemonValue = water.Lemon;
                    }

                    if (drink.Ice) {
                        HasIce = true;
                        uxIce.Background = Brushes.LightBlue;
                        uxIce.Content = "Remove Ice";
                    } else {
                        HasIce = false;
                        uxIce.Background = Brushes.White;
                        uxIce.Content = "Add Ice";
                    }
                } else {
                    uxIce.Visibility = Visibility.Collapsed;
                    uxLemon.Visibility = Visibility.Collapsed;
                    uxExtraData.Visibility = Visibility.Collapsed;
                }
            }
        }


        /// <summary>
        /// Adds the passed in drink to the order.
        /// </summary>
        /// <param name="drink">The drink to add to the order.</param>
        private void AddItem(Drink drink) {
            if (DataContext is Order order) {
                drink.Size = Size;
                order.Items.Add(drink);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
    }
}

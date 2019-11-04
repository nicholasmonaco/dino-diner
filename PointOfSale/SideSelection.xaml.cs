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
using DinoDiner.Menu;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page {

        /// <summary>
        /// The page to return to when the side is done being selected.
        /// </summary>
        private Page _returnPage;

        /// <summary>
        /// The currently edited side, if applicable.
        /// </summary>
        private Side editedSide;


        /// <summary>
        /// Gets and sets the size of the side.
        /// The setter is marked private.
        /// </summary>
        public DinoDiner.Menu.Size Size { get; private set; }


        /// <summary>
        /// Constructs the SideSelection page.
        /// </summary>
        public SideSelection() {
            InitializeComponent();
            this.ShowsNavigationUI = false;

            this.DataContext = this;

            uxFryceritops.Background = Brushes.White;
            uxMeteorMac.Background = Brushes.White;
            uxMezzorellaSticks.Background = Brushes.White;
            uxTriceritots.Background = Brushes.White;

            uxSmallBox.Background = Brushes.White;
            uxMediumBox.Background = Brushes.White;
            uxLargeBox.Background = Brushes.White;

            _returnPage = new MenuCategorySelection();
            editedSide = null;
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
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side) {
                    side.Size = DinoDiner.Menu.Size.Small;
                }
            }

            if (_returnPage is CustomizeCombo page) {
                page.SetSide(editedSide);
            }
            NavigationService.Navigate(_returnPage);
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
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side) {
                    side.Size = DinoDiner.Menu.Size.Medium;
                }
            }

            if (_returnPage is CustomizeCombo page) {
                page.SetSide(editedSide);
            }
            NavigationService.Navigate(_returnPage);
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
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side) {
                    side.Size = DinoDiner.Menu.Size.Large;
                }
            }

            if(_returnPage is CustomizeCombo page) {
                page.SetSide(editedSide);
            }
            NavigationService.Navigate(_returnPage);
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

            if (editedSide == null) {
                AddItem(new Fryceritops());
            } else {
                Fryceritops item = new Fryceritops();
                item.Size = editedSide.Size;
                editedSide = item;
            }
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

            if (editedSide == null) {
                AddItem(new MeteorMacAndCheese());
            } else {
                MeteorMacAndCheese item = new MeteorMacAndCheese();
                item.Size = editedSide.Size;
                editedSide = item;
            }
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

            if (editedSide == null) {
                AddItem(new MezzorellaSticks());
            } else {
                MezzorellaSticks item = new MezzorellaSticks();
                item.Size = editedSide.Size;
                editedSide = item;
            }
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

            if(editedSide == null) {
                AddItem(new Triceritots());
            } else {
                Triceritots item = new Triceritots();
                item.Size = editedSide.Size;
                editedSide = item;
            }
        }

        /// <summary>
        /// Sets the currently edited side, updates the page accordingly, and sets the page
        /// to navigate to after the side is done being selected.
        /// </summary>
        /// <param name="side">The side to load in.</param>
        /// <param name="returnPage">The page to return to when the side is done being selected.</param>
        public void SetEditedSide(Side side, Page returnPage) {
            _returnPage = returnPage;

            editedSide = side;

            uxFryceritops.Background = Brushes.White;
            uxMeteorMac.Background = Brushes.White;
            uxMezzorellaSticks.Background = Brushes.White;
            uxTriceritots.Background = Brushes.White;

            uxSmallBox.Background = Brushes.White;
            uxMediumBox.Background = Brushes.White;
            uxLargeBox.Background = Brushes.White;
            Size = side.Size;

            if (side is Fryceritops fry) {
                uxFryceritops.Background = Brushes.LightBlue;
            } else if (side is MeteorMacAndCheese mmc) {
                uxMeteorMac.Background = Brushes.LightBlue;
            } else if (side is MezzorellaSticks ms) {
                uxMezzorellaSticks.Background = Brushes.LightBlue;
            } else if (side is Triceritots tt) {
                uxTriceritots.Background = Brushes.LightBlue;
            }

            if(side.Size == DinoDiner.Menu.Size.Small) {
                uxSmallBox.Background = Brushes.LightBlue;
            } else if (side.Size == DinoDiner.Menu.Size.Medium) {
                uxSmallBox.Background = Brushes.LightBlue;
            } else if (side.Size == DinoDiner.Menu.Size.Large) {
                uxLargeBox.Background = Brushes.LightBlue;
            }
        }

        /// <summary>
        /// Handles what happens on the page when the selected item in the order is changed.
        /// </summary>
        public void UpdateButtons() {
            uxFryceritops.Background = Brushes.White;
            uxMeteorMac.Background = Brushes.White;
            uxMezzorellaSticks.Background = Brushes.White;
            uxTriceritots.Background = Brushes.White;

            uxSmallBox.Background = Brushes.White;
            uxMediumBox.Background = Brushes.White;
            uxLargeBox.Background = Brushes.White;


            if (DataContext is Order order) {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side) {
                    /*Size = side.Size;
                    switch (Size) {
                        case DinoDiner.Menu.Size.Small:
                            uxSmallBox.Background = Brushes.LightBlue;
                            break;
                        case DinoDiner.Menu.Size.Medium:
                            uxLargeBox.Background = Brushes.LightBlue;
                            break;
                        case DinoDiner.Menu.Size.Large:
                            uxLargeBox.Background = Brushes.LightBlue;
                            break;
                    }*/

                    if(side is Fryceritops fry) {
                        uxFryceritops.Background = Brushes.LightBlue;
                    }else if(side is MeteorMacAndCheese mac) {
                        uxMeteorMac.Background = Brushes.LightBlue;
                    } else if(side is MezzorellaSticks sticks) {
                        uxMezzorellaSticks.Background = Brushes.LightBlue;
                    } else if(side is Triceritots tots) {
                        uxTriceritots.Background = Brushes.LightBlue;
                    }
                }
            }
        }


        /// <summary>
        /// Adds the passed in side to the order.
        /// </summary>
        /// <param name="side">The side to add to the order.</param>
        private void AddItem(Side side) {
            if (DataContext is Order order) {
                side.Size = Size;
                order.Add(side);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
    }
}

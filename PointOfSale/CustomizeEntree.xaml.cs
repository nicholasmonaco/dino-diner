/*  CustomizeEntree.cs
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
    /// Interaction logic for CustomizeEntree.xaml
    /// </summary>
    public partial class CustomizeEntree : Page {

        /// <summary>
        /// The entree item currently being changed, if applicable.
        /// </summary>
        private Entree editedEntree;

        /// <summary>
        /// The page to navigate to when the Done button is clicked.
        /// </summary>
        private Page _returnPage;

        /// <summary>
        /// The main Grid of the xaml page.
        /// </summary>
        private Grid optionsGrid;

        /// <summary>
        /// A list containing all possible holdable options as string messages.
        /// </summary>
        private List<string> optionButtonTexts;

        /// <summary>
        /// A list containing all of the possible holdable option buttons.
        /// </summary>
        private List<Button> optionButtons;

        /// <summary>
        /// Displays how many nuggets the current order of Dino-Nuggets has, if applicable.
        /// Doesn't exist if the current entree isn't Dino-Nuggets.
        /// </summary>
        private TextBlock uxNuggetCounter;


        /// <summary>
        /// Constructor for the CustomizeEntree page.
        /// </summary>
        public CustomizeEntree() {
            InitializeComponent();
            optionsGrid = uxMainGrid;
            _returnPage = new MenuCategorySelection();
            editedEntree = null;
        }


        /// <summary>
        /// Handles what happens when the Done button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        public void DoneButtonClicked(object sender, RoutedEventArgs e) {
            if(sender is Button b1) {
                if(_returnPage is CustomizeCombo page) {
                    page.SetEntree(editedEntree);
                }
                NavigationService.Navigate(_returnPage);
            }
        }

        /// <summary>
        /// Handles what happens when a hold button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        public void ToggleButtonClicked(object sender, RoutedEventArgs e) {
            if(sender is Button b1) {
                int index = (int)b1.Tag;
                bool val;

                if(b1.Background == Brushes.LightBlue) {
                    b1.Background = Brushes.White;
                    b1.Content = "Hold " + optionButtonTexts[index];
                    val = true;
                } else {
                    b1.Background = Brushes.LightBlue;
                    b1.Content = "Add " + optionButtonTexts[index];
                    val = false;
                }

                

                if(editedEntree == null) {
                    if (DataContext is Order order) {
                        if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Entree entree) {
                            entree.ChangeHold(index, val);
                        } else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo) {
                            combo.Entree.ChangeHold(index, val);
                        }
                    }
                } else {
                    editedEntree.ChangeHold(index, val);

                    UpdateCurrentItem();
                }
            }
        }

        /// <summary>
        /// Toggles a certain hold button with the specified value.
        /// </summary>
        /// <param name="index">The index of the target button.</param>
        /// <param name="b">The value to change it to represent.</param>
        private void ToggleBool(int index, bool b) {
            if(b == true) {
                optionButtons[index].Background = Brushes.White;
                optionButtons[index].Content = "Hold " + optionButtonTexts[index];
            } else {
                optionButtons[index].Background = Brushes.LightBlue;
                optionButtons[index].Content = "Add " + optionButtonTexts[index];
            }
        }

        /// <summary>
        /// Handles what happens when the Add Nugget button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        public void AddNuggetButtonClicked(object sender, RoutedEventArgs e) {
            if(editedEntree == null) {
                if (DataContext is Order order) {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoNuggets nuggets) {
                        nuggets.AddNugget();
                        uxNuggetCounter.Text = nuggets.NuggetCount + " Nuggets";
                    }
                }
            } else {
                if(editedEntree is DinoNuggets nuggets){
                    nuggets.AddNugget();
                    uxNuggetCounter.Text = nuggets.NuggetCount + " Nuggets";

                    UpdateCurrentItem();
                }
                
            }
        }

        /// <summary>
        /// Handles what happens when the Remove Nugget button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        public void RemoveNuggetButtonClicked(object sender, RoutedEventArgs e) {
            if (editedEntree == null) {
                if (DataContext is Order order) {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoNuggets nuggets) {
                        nuggets.RemoveNugget();
                        uxNuggetCounter.Text = nuggets.NuggetCount + " Nuggets";
                    }
                }
            } else {
                if (editedEntree is DinoNuggets nuggets) {
                    nuggets.RemoveNugget();
                    uxNuggetCounter.Text = nuggets.NuggetCount + " Nuggets";

                    UpdateCurrentItem();
                }
            }
        }

        /// <summary>
        /// Updates the current item in the Order UI to reflect editedEntree.
        /// </summary>
        private void UpdateCurrentItem() {
            if (DataContext is Order order) {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Entree entree) {
                    order.Items[order.Items.IndexOf(entree)] = editedEntree;
                } else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo) {
                    combo.Entree = editedEntree;
                    order.Items[order.Items.IndexOf(combo)] = combo;
                }
            }
        }

        /// <summary>
        /// Sets the current editable entree and adjusts the option buttons accordingly.
        /// </summary>
        /// <param name="e">The entree being edited.</param>
        public void SetEditedEntree(Entree e) {
            editedEntree = e;

            if (e is Brontowurst b) {
                ToggleBool(0, b.Bun);
                ToggleBool(1, b.Peppers);
                ToggleBool(2, b.Onion);
            } else if (e is PrehistoricPBJ pbj) {
                ToggleBool(0, pbj.PeanutButter);
                ToggleBool(1, pbj.Jelly);
            } else if (e is PterodactylWings pw) {
                // Nothing goes here right now, but it exists.
            } else if (e is SteakosaurusBurger sb) {
                ToggleBool(0, sb.Bun);
                ToggleBool(1, sb.Pickle);
                ToggleBool(2, sb.Ketchup);
                ToggleBool(3, sb.Mustard);
            } else if (e is TRexKingBurger trex) {
                ToggleBool(0, trex.Bun);
                ToggleBool(1, trex.Lettuce);
                ToggleBool(2, trex.Tomato);
                ToggleBool(3, trex.Onion);
                ToggleBool(4, trex.Pickle);
                ToggleBool(5, trex.Ketchup);
                ToggleBool(6, trex.Mustard);
                ToggleBool(7, trex.Mayo);
            } else if (e is VelociWrap vw) {
                ToggleBool(0, vw.Dressing);
                ToggleBool(1, vw.Lettuce);
                ToggleBool(2, vw.Cheese);
            }
        }

        /// <summary>
        /// Initializes the buttons on the page and sets the return page.
        /// </summary>
        /// <param name="entree">The entree to customize.</param>
        /// <param name="returnPage">The page to navigate back to after the Done button is clicked.</param>
        public void InitPage(Entree entree, Page returnPage) {
            _returnPage = returnPage;

            optionButtons = new List<Button>();
            optionButtonTexts = new List<string>();

            if (entree is Brontowurst b) {
                optionButtonTexts.Add("Bun");
                optionButtonTexts.Add("Peppers");
                optionButtonTexts.Add("Onion");
            } else if(entree is DinoNuggets dn) {
                InitNuggetButtons();
            } else if (entree is PrehistoricPBJ pbj) {
                optionButtonTexts.Add("Peanut Butter");
                optionButtonTexts.Add("Jelly");
            } else if (entree is PterodactylWings pw) {
                // Nothing goes here right now, but it exists.
            } else if (entree is SteakosaurusBurger sb) {
                optionButtonTexts.Add("Bun");
                optionButtonTexts.Add("Pickle");
                optionButtonTexts.Add("Ketchup");
                optionButtonTexts.Add("Mustard");
            } else if (entree is TRexKingBurger trex) {
                optionButtonTexts.Add("Bun");
                optionButtonTexts.Add("Lettuce");
                optionButtonTexts.Add("Tomato");
                optionButtonTexts.Add("Onion");
                optionButtonTexts.Add("Pickle");
                optionButtonTexts.Add("Ketchup");
                optionButtonTexts.Add("Mustard");
                optionButtonTexts.Add("Mayo");
            } else if (entree is VelociWrap vw) {
                optionButtonTexts.Add("Dressing");
                optionButtonTexts.Add("Lettuce");
                optionButtonTexts.Add("Cheese");
            }

            for (int i = 0; i < optionButtonTexts.Count; i++) {
                Button b1 = new Button();
                b1.Width = 100;
                b1.Height = 100;
                b1.Margin = new Thickness(10, 10, 10, 10);
                b1.Background = Brushes.White;
                b1.Content = "Hold " + optionButtonTexts[i];
                b1.Tag = i;
                b1.Click += ToggleButtonClicked;
                b1.HorizontalAlignment = HorizontalAlignment.Center;
                b1.VerticalAlignment = VerticalAlignment.Center;
                Grid.SetColumn(b1, i % 3);
                Grid.SetRow(b1, i / 3);

                optionButtons.Add(b1);
                
                optionsGrid.Children.Add(optionButtons[i]);
            }
        }

        /// <summary>
        /// Creates the 2 Dino-Nugget specific buttons and uxNuggetCounter.
        /// </summary>
        private void InitNuggetButtons() {
            Button b1 = new Button();
            b1.Width = 100;
            b1.Height = 100;
            b1.Margin = new Thickness(10, 10, 10, 10);
            b1.Content = "Add Nugget";
            b1.Click += AddNuggetButtonClicked;
            b1.HorizontalAlignment = HorizontalAlignment.Center;
            b1.VerticalAlignment = VerticalAlignment.Center;
            Grid.SetColumn(b1, 1);
            Grid.SetRow(b1, 0);

            Button b2 = new Button();
            b2.Width = 100;
            b2.Height = 100;
            b2.Margin = new Thickness(10, 10, 10, 10);
            b2.Content = "Remove Nugget";
            b2.Click += RemoveNuggetButtonClicked;
            b2.HorizontalAlignment = HorizontalAlignment.Center;
            b2.VerticalAlignment = VerticalAlignment.Center;
            Grid.SetColumn(b2, 1);
            Grid.SetRow(b2, 1);

            TextBlock tb = new TextBlock();
            tb.Width = 100;
            tb.Height = 100;
            tb.Margin = new Thickness(10, 10, 10, 10);
            tb.Text = "6 Nuggets";
            tb.Name = "uxNuggetCounter";
            tb.HorizontalAlignment = HorizontalAlignment.Center;
            tb.VerticalAlignment = VerticalAlignment.Center;
            tb.TextAlignment = TextAlignment.Center;
            Grid.SetColumn(tb, 1);
            Grid.SetRow(tb, 2);
            uxNuggetCounter = tb;

            optionsGrid.Children.Add(b1);
            optionsGrid.Children.Add(b2);
            optionsGrid.Children.Add(uxNuggetCounter);
        }


    }
}

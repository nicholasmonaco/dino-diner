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
using DinoDiner.Menu;

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
            this.ShowsNavigationUI = false;

            this.DataContext = this;
        }

        /// <summary>
        /// Handles what happens when an entree button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="args">The RoutedEventArgs.</param>
        private void EntreeClick(object sender, RoutedEventArgs args) {
            Button b = sender as Button;
            if(b != null) {
                switch (b.Tag) {
                    case "Brontowurst":
                        AddItem(new Brontowurst());
                        break;
                    case "DinoNuggets":
                        AddItem(new DinoNuggets());
                        break;
                    case "PrehistoricPBJ":
                        AddItem(new PrehistoricPBJ());
                        break;
                    case "PterodactylWings":
                        AddItem(new PterodactylWings());
                        break;
                    case "SteakosaurusBurger":
                        AddItem(new SteakosaurusBurger());
                        break;
                    case "TRexKingBurger":
                        AddItem(new TRexKingBurger());
                        break;
                    case "VelociWrap":
                        AddItem(new VelociWrap());
                        break;
                }
            }

            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Adds the passed in entree to the order.
        /// </summary>
        /// <param name="entree">The entree to add to the order.</param>
        private void AddItem(Entree entree) {
            if (DataContext is Order order) {
                order.Items.Add(entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        
    }
}

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
using DinoDiner.Menu;

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
            Entree entree = new SteakosaurusBurger();
            string entreeName = (string)((Button)sender).Tag;
            switch (entreeName) {
                case "Brontowurst":
                    entree = new Brontowurst();
                    break;
                case "Steakosaurus":
                    entree = new SteakosaurusBurger();
                    break;
                case "T-Rex":
                    entree = new TRexKingBurger();
                    break;
                case "Prehistoric":
                    entree = new PrehistoricPBJ();
                    break;
                case "Pterodactyl":
                    entree = new PterodactylWings();
                    break;
                case "Veloci-Wrap":
                    entree = new VelociWrap();
                    break;
                case "Dino-Nuggets":
                    entree = new DinoNuggets();
                    break;
            }

            if (DataContext is Order order) {
                order.Add(new CretaceousCombo(entree));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();

                CustomizeCombo page = new CustomizeCombo();
                page.SetCombo((CretaceousCombo)order.Items.Last<IOrderItem>());
                NavigationService.Navigate(page);
            }
        }

        /// <summary>
        /// Handles what happens when the Done button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs</param>
        private void DoneClick(object sender, RoutedEventArgs e) {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}

/*  CustomizeCombo.cs
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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page {

        /// <summary>
        /// The combo item.
        /// </summary>
        private CretaceousCombo _combo;

        /// <summary>
        /// The page to navigate to when the Done button is clicked.
        /// </summary>
        private Page _returnPage;


        /// <summary>
        /// Gets and sets the size of the combo.
        /// The setter is marked private.
        /// </summary>
        public DinoDiner.Menu.Size Size { get; private set; }

        /// <summary>
        /// Constructs the CustomizeCombo page.
        /// </summary>
        public CustomizeCombo() {
            InitializeComponent();
            this.ShowsNavigationUI = false;

            uxSmallBox.Background = Brushes.LightBlue;
            uxMediumBox.Background = Brushes.White;
            uxLargeBox.Background = Brushes.White;
            Size = DinoDiner.Menu.Size.Small;
            //_combo.Size = DinoDiner.Menu.Size.Small;
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
            _combo.Size = DinoDiner.Menu.Size.Small;

            if (DataContext is Order order) {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo com) {
                    com.Size = _combo.Size;
                }
            }

            SetSide(_combo.Side);
            SetDrink(_combo.Drink);
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
            _combo.Size = DinoDiner.Menu.Size.Medium;

            if (DataContext is Order order) {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo com) {
                    com.Size = _combo.Size;
                    Console.WriteLine("Combo has really been set to medium.");
                }
            }

            SetSide(_combo.Side);
            SetDrink(_combo.Drink);
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
            _combo.Size = DinoDiner.Menu.Size.Large;

            if (DataContext is Order order) {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo com) {
                    com.Size = _combo.Size;
                }
            }

            SetSide(_combo.Side);
            SetDrink(_combo.Drink);
        }

        /// <summary>
        /// Handles what happens when the Side button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void SideClick(object sender, RoutedEventArgs e) {
            SideSelection page = new SideSelection();
            page.SetEditedSide(_combo.Side, this);
            NavigationService.Navigate(page);
        }

        /// <summary>
        /// Handles what happens when the Drink button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void DrinkClick(object sender, RoutedEventArgs e) {
            DrinkSelection page = new DrinkSelection();
            page.SetReturnPage(this);
            page.SetEditedDrink(_combo.Drink);
            NavigationService.Navigate(page);
        }

        /// <summary>
        /// Handles what happens when the Customize Entree button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs.</param>
        private void EntreeClick(object sender, RoutedEventArgs e) {
            CustomizeEntree page = new CustomizeEntree();
            page.InitPage(_combo.Entree, this);
            page.SetEditedEntree(_combo.Entree);
            NavigationService.Navigate(page);
        }

        /// <summary>
        /// Handles what happens when the Done button is clicked.
        /// </summary>
        /// <param name="sender">The object being clicked.</param>
        /// <param name="e">The RoutedEventArgs</param>
        private void DoneClick(object sender, RoutedEventArgs e) {
            NavigationService.Navigate(new MenuCategorySelection());
            Console.WriteLine("When done, the combo size is " + _combo.Size);
        }

        /// <summary>
        /// Sets the entree of the combo,
        /// </summary>
        /// <param name="entree">The entree to set as the combo's entree.</param>
        public void SetEntree(Entree entree) {
            _combo.Entree = entree;
        }

        /// <summary>
        /// Sets the side of the combo,
        /// </summary>
        /// <param name="entree">The side to set as the combo's side.</param>
        public void SetSide(Side side) {
            side.Size = this.Size;
            _combo.Side = side;
            uxSide.Content = side.Description;
        }

        /// <summary>
        /// Sets the drink of the combo,
        /// </summary>
        /// <param name="entree">The drink to set as the combo's drink.</param>
        public void SetDrink(Drink drink) {
            drink.Size = this.Size;
            _combo.Drink = drink;
            uxDrink.Content = drink.Description;
        }

        /// <summary>
        /// Sets the combo.
        /// </summary>
        /// <param name="combo">The combo to set.</param>
        public void SetCombo(CretaceousCombo combo) {
            _combo = combo;
            SetSide(combo.Side);
            SetDrink(combo.Drink);
            Size = combo.Size;

            uxSmallBox.Background = Brushes.White;
            uxMediumBox.Background = Brushes.White;
            uxLargeBox.Background = Brushes.White;
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
        }

        /// <summary>
        /// Sets the page to navigate to when the Done button is clicked.
        /// </summary>
        /// <param name="page">The page to navigate to.</param>
        public void SetReturnPage(Page page) {
            _returnPage = page;
        }

    }
}

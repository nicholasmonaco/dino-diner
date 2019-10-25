/*  MainWindow.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor for MainWindow.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            OrderControl.uxListBox.SelectionChanged += SelectedItemChanged;
        }

        /// <summary>
        /// Handles what happens if the currently selected item in the order is changed.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="args">The SelectionChangedEvetnArgs tied to this event.</param>
        private void SelectedItemChanged(object sender, SelectionChangedEventArgs args) {
            if(OrderUI.Content is SideSelection sideSelect) {
                sideSelect.UpdateButtons();
            }else if(OrderUI.Content is DrinkSelection drinkSelect) {
                drinkSelect.UpdateButtons();
            } // There's no other pages here yet, but there could be if needed.
        }

        /// <summary>
        /// The method that handles passing down the DataContext through the pages.
        /// </summary>
        private void PassOnDataContext() {
            Page page = OrderUI.Content as Page;
            if(page != null) {
                page.DataContext = OrderUI.DataContext;
            }
        }

        /// <summary>
        /// Passes on the DataContext when a new page is loaded.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="args">The NavigationEventArgs tied to this event.</param>
        public void OnLoadCompleted(object sender, NavigationEventArgs args) {
            PassOnDataContext();
        }

        /// <summary>
        /// Passes on the DataContext if the current DataContext is changed.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="args">The DependencyPropertyChangedEventArgs tied to this event.</param>
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args) {
            PassOnDataContext();
        }
    }
}

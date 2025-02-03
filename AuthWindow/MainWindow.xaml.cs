using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static AuthWindow.Product.IProduct;

namespace AuthWindow
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<IProduct> _products = new ObservableCollection<IProduct>(); 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            if (decimal.TryParse(PriceTextBox.Text, out decimal price))
            {
                _products.Add(item: new AuthWindow(name, price));

               
                ProductListBox.ItemsSource = null;
                ProductListBox.ItemsSource = _products;
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректную цену.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private interface IProduct
        {
        }
    }
}


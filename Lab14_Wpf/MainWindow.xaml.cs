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

namespace Lab14_Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Батон белый",
                ProductImage = 1,
                ProductPrice = 50,
                ProductCategory = ProductCategorys.Food,
            });

            products.Add(new Product()
            {
                ProductName = "Будильник",
                ProductImage = 2,
                ProductPrice = 250,
                ProductCategory = ProductCategorys.Appliances,
            });
            products.Add(new Product()
            {
                ProductName = "Мармелад",
                ProductImage = 3,
                ProductPrice = 150,
                ProductCategory = ProductCategorys.Food,
            });
            lstBox.ItemsSource = products;
        }
    }
}




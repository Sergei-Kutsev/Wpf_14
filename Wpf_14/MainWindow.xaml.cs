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
using System.Collections;
using System.Collections.ObjectModel;

namespace Wpf_14
{
   
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;

        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                Name = "Батон",
                Price = 34.99,
                ProductType = ProductTypes.Food,
               ProductImage = "Images/bread.jpg",
            });

            products.Add(new Product()
            {
                Name = "Терафлю",
                Price = 425.40,
                ProductType = ProductTypes.Medicine,
                ProductImage = "Images/teraflu.jpeg",
            });

            products.Add(new Product()
            {
                Name = "Молоко",
                Price = 64.99,
                ProductType = ProductTypes.Food,
                ProductImage = "Images/milk.jpg",
            });


            products.Add(new Product()
            {
                Name = "Нурофен",
                Price = 253.70,
                ProductType = ProductTypes.Medicine,
                ProductImage = "Images/Nurofen.jpeg",
            });
            listBox.ItemsSource = products;
        }
    }
}

using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_2_8_1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public ObservableCollection<Product> products = new ObservableCollection<Product>();
    public MainWindow()
    {
        InitializeComponent();
        products.Add(new Product()
        {
            ProductName = "Яблоки",
            ProductCost=200,
            ProductImage="/Img/Яблоко.png",
            ProductType=ProductTypes.Food
        });
        products.Add(new Product()
        {
            ProductName = "Стиральная машина",
            ProductCost = 20000,
            ProductImage = "/Img/Стиралка.png",
            ProductType = ProductTypes.Technique
        });
        products.Add(new Product()
        {
            ProductName = "Бананы",
            ProductCost = 300,
            ProductImage = "/Img/Бананы.png",
            ProductType = ProductTypes.Food
        });
        products.Add(new Product()
        {
            ProductName = "Холодильник",
            ProductCost = 25000,
            ProductImage = "/Img/Холодильник.png",
            ProductType = ProductTypes.Technique
        });
        lstBox.ItemsSource = products;
    }
}
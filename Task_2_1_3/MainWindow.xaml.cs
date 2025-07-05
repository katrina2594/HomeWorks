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

namespace Task_2_1_3;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button1_MouseEnter(object sender, MouseEventArgs e)
    {
        
        Random rnd = new Random();
        int newLeft = rnd.Next(0,(int)(MainGrid.ActualWidth-Button1.ActualWidth));
        int newTop = rnd.Next(0, (int)(MainGrid.ActualHeight-Button1.ActualHeight));
        Button1.Margin = new Thickness(newLeft, newTop, 0, 0);

    }
}
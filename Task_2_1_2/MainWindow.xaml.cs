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

namespace Task_2_1_2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button1_Click(object sender, RoutedEventArgs e)
    {
        if (EllipseRed.Fill.Equals(Brushes.Red))
        {
            EllipseRed.Fill = Brushes.Gray;
            EllipseYellow.Fill = Brushes.Yellow;
        }
        else
        {
            if (EllipseYellow.Fill.Equals(Brushes.Yellow))
            {
                EllipseYellow.Fill = Brushes.Gray;
                EllipseGreen.Fill = Brushes.Green;
            }
            else
            {
                EllipseGreen.Fill = Brushes.Gray;
                EllipseRed.Fill = Brushes.Red;
            }
        }

    }
}
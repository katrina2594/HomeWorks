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

namespace test;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public ObservableCollection<HeaderViewModel> Headers { get; set; }
    public MainWindow()
    {
        InitializeComponent();
        Headers = new ObservableCollection<HeaderViewModel>
            {
                new HeaderViewModel
                {
                    Title = "Header 1",
                    SubHeaders =
                    {
                        new SubHeaderViewModel
                        {
                            Title = "SubHeader 1.1",
                            SubHeaders =
                            {
                                new ThirdLevelHeaderViewModel { Title = "ThirdLevel 1.1.1" },
                                new ThirdLevelHeaderViewModel { Title = "ThirdLevel 1.1.2" }
                            }
                        },
                        new SubHeaderViewModel
                        {
                            Title = "SubHeader 1.2",
                            SubHeaders =
                            {
                                new ThirdLevelHeaderViewModel { Title = "ThirdLevel 1.2.1" }
                            }
                        }
                    }
                },
                new HeaderViewModel
                {
                    Title = "Header 2",
                    SubHeaders =
                    {
                        new SubHeaderViewModel
                        {
                            Title = "SubHeader 2.1",
                            SubHeaders =
                            {
                                new ThirdLevelHeaderViewModel { Title = "ThirdLevel 2.1.1" },
                                new ThirdLevelHeaderViewModel { Title = "ThirdLevel 2.1.2" }
                            }
                        }
                    }
                }
            };
        DataContext = this;
    }
}
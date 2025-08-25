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

namespace Task_2_9_1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private Stack<Brush> _colorHistory = new Stack<Brush>();
    private Brush _currentColor;
    public Brush CurrentColor
    {
        get => _currentColor;
        set
        {
            _currentColor = value;
            if (_colorHistory.Count == 0 || _colorHistory.Peek() != value)
            {
                if (value != null)
                    _colorHistory.Push(value);
            }
            MyGrid.Background = _currentColor;
        }
    }
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ChangeColorExecuted(object sender, ExecutedRoutedEventArgs e)
    {
        var random = new Random();
        CurrentColor = new SolidColorBrush(Color.FromRgb(
            (byte)random.Next(256),
            (byte)random.Next(256),
            (byte)random.Next(256)));
    }
    private void UndoExecuted(object sender, ExecutedRoutedEventArgs e)
    {
        if (_colorHistory.Count > 0)
        {
            _colorHistory.Pop();
            if (_colorHistory.Count != 0)
                CurrentColor = _colorHistory.Pop();
            else
                CurrentColor = null;
        }
    }

    private void UndoCanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
        if(_colorHistory.Count>0)
        {
            e.CanExecute = true;
        }
        else
        {
            e.CanExecute = false;
        }
    }
}
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

namespace Task_2_3_1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (!MailingCheckBox.IsChecked ?? false|| UserName.Text.Equals("")|| ListBox1.SelectedItems.Count<1)
        {
            if (UserName.Text.Equals(""))
            {
                MessageBox.Show("Заполните имя студента", "", MessageBoxButton.OK);
            }
            if (ListBox1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Выберите хотя бы 1 курс", "", MessageBoxButton.OK);
            }
            if (!MailingCheckBox.IsChecked ?? false)
            {
                MessageBox.Show("Необходимо согласие на обработку данных", "", MessageBoxButton.OK);
            }
        }
        else
        {
            string studentName = UserName.Text;
            string faculty = Faculty.Text;
            string courses = string.Join(",", ListBox1.SelectedItems
                .Cast<ListBoxItem>()
                .Select(item => item.Content.ToString())
                .ToList());
            MessageBox.Show($"Студент: {studentName} " +
                $"\nФакультет: {faculty} " +
                $"\nКурсы: {courses}", "Данные отправлены", MessageBoxButton.OK);
        }
    }

    private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        hourCount.Text = Slider1.Value.ToString();
    }

    private void hourCount_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (Slider1 != null && int.TryParse(hourCount.Text, out int result))
            Slider1.Value = result;
    }

    private void hourCount_PreviewTextInput(object sender, TextCompositionEventArgs e)
    {
        if(int.TryParse(e.Text,out int result))
        {
            e.Handled = false;
        }
        
    }
}
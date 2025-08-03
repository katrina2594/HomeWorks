using System.IO;
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
using Microsoft.Win32;

namespace Task_2_2_1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ButtonOpen_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
        if (openFileDialog.ShowDialog() == true)
        {
            textBox1.Text = File.ReadAllText(openFileDialog.FileName);
            StatusText.Text = openFileDialog.FileName;
        }
    }

    private void ButtonSave_Click(object sender, RoutedEventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Текстовые файлы(*.txt) | *.txt | Все файлы(*.*) | *.* ";
        if(saveFileDialog.ShowDialog()==true)
        {
            File.WriteAllText(saveFileDialog.FileName,textBox1.Text);
            StatusText.Text = "Файл сохранен";
        }
       
    }

    private void ButtonInfo_Click(object sender, RoutedEventArgs e)
    {
        WindowProgramAbout windowProgramAbout = new WindowProgramAbout();
        windowProgramAbout.WindowStyle = WindowStyle.SingleBorderWindow;
        windowProgramAbout.Show();
    }

    private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
        MessageBoxResult messageBoxresult = MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение",
            MessageBoxButton.YesNo, MessageBoxImage.Question);
        if(messageBoxresult==MessageBoxResult.No)
        {
            e.Cancel = true;
        }
    }
}
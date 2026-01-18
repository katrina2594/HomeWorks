using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Task_RevitAPI_8.ViewModels;
using Task_RevitAPI_8.Views;

namespace Task_RevitAPI_8
{
    [Transaction(TransactionMode.Manual)]
    internal class Cmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel(commandData);
            MainWindow window = new MainWindow();
            window.DataContext = mainWindowViewModel;
            window.Show();
            return Result.Succeeded;
        }
    }
}

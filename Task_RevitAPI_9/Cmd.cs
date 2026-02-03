using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Microsoft.Extensions.DependencyInjection;
using Task_RevitAPI_9.Abstractions;
using Task_RevitAPI_9.Services;
using Task_RevitAPI_9.ViewModels;
using Task_RevitAPI_9.Views;

namespace Task_RevitAPI_9
{
    [Transaction(TransactionMode.Manual)]
    public class Cmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            

            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<ExternalCommandData>(commandData);
            services.AddSingleton<RevitTask>(new RevitTask());
            services.AddSingleton<ISelectionService, SelectionService>();
            services.AddSingleton<ISectionService, SectionService>();
            services.AddSingleton<MainWindowViewModel, MainWindowViewModel>();
            services.AddSingleton<MainWindow, MainWindow>();
            var provider = services.BuildServiceProvider();

            var mainWindow = provider.GetRequiredService<MainWindow>();
            mainWindow.Show();

            return Result.Succeeded;
        }
    }
}

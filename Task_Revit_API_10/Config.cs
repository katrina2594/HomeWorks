using Task_Revit_API_10.Abstractions;
using Task_Revit_API_10.Services;
using Task_Revit_API_10.ViewModels;
using Task_Revit_API_10.Views;
using Microsoft.Extensions.DependencyInjection;
using RxBim.Di;

namespace Task_Revit_API_10
{
    internal class Config : ICommandConfiguration
    {
        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<IPlacementService, PlacementService>();
            services.AddSingleton<MainWindowViewModel, MainWindowViewModel>();
            services.AddSingleton<MainWindow, MainWindow>();
        }
    }
}

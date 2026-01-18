using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows.Media;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Task_RevitAPI_8.Models;
using Task_RevitAPI_8.Services;

namespace Task_RevitAPI_8.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged

    {
        private readonly ExternalCommandData _commandData;
        public MainWindowViewModel(ExternalCommandData commandData)
        {
            _commandData = commandData;
            WallCheck = new RelayCommand(OnWallCheckExecute);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private WallInfo _wallInfo;
        public WallInfo WallInfo
        {
            get => _wallInfo;
            set
            {
                _wallInfo = value;
                OnPropertyChanged();
            }
        }
        private double _limit;
        public double Limit
        {
            get => _limit;
            set
            {
                _limit = value;
                OnPropertyChanged();
            }
        }
        public ICommand WallCheck {  get; }
        
        private void OnWallCheckExecute(object parameter)
        {
            SelectionService selectionService = new SelectionService(_commandData);
            Wall wall = selectionService.PickWall();
            if (wall == null) 
            { 
                return;
            }

            GeometryService geometryService = new GeometryService(_commandData);
            WallInfo = geometryService.GetWallInfo(wall,Limit);
        }
    }
}

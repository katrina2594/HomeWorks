using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Task_2_10_1.Models;

namespace Task_2_10_1.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string username;
        public string Username
        {
            get => username;
            set
            {
                username = value;
                OnPropertyChanged();
            }
        }
        private string password;
        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }
        private string statusMessage;
        public string StatusMessage
        {
            get => statusMessage;
            set
            {
                statusMessage = value;
                OnPropertyChanged();
            }
        }
        private bool isSuccess;
        public bool IsSuccess
        {
            get => isSuccess;
            set
            {
                isSuccess = value;
                OnPropertyChanged();
            }
        }
        public ICommand LoginCommand { get; }

        private void OnLoginCommandExecute(object? parameter)
        {
            if (AuthModel.Authenticate(Username, Password))
            {
                StatusMessage = "Успешный вход! Добро пожаловать!";
                IsSuccess = true;
            }
            else
            {
                StatusMessage = "Введите учетные данные";
                IsSuccess = false;
            }
        }

        private bool CanLoginCommandExecuted(object? parameter)
        {
            return Username != null && Password != null && Username.Length > 0 && Password.Length > 0;
        }

        public MainWindowViewModel()
        {
            LoginCommand = new RelayCommand(OnLoginCommandExecute, CanLoginCommandExecuted);
            StatusMessage = "Введите учетные данные";
            IsSuccess = false;

        }
    }
}

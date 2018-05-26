using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Windows.Input;

namespace Client.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public ICommand NavigateToCustomerCommand { get; set; }
        public ICommand NavigateToLinesCommand { get; set; }

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            NavigateToCustomerCommand = new RelayCommand(() =>
              {
                  _navigationService.NavigateTo("CustomerPage");
              });
            NavigateToLinesCommand = new RelayCommand(() =>
              {
                  _navigationService.NavigateTo("LinePage");
              });
        }
    }
}
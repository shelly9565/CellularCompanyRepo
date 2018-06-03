using Client.CRMServiceReference;
using Common.Dtoes;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.ViewModel
{
    public class CustomerViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public CustomerDto Customer { get; set; }
        public int CustomerId { get; set; }

        public ObservableCollection<int> CustomerIds { get; set; }
        public ObservableCollection<CustomerTypeDto> CustomerTypes { get; set; }

        public ICommand AddOrUpdateCommand { get; set; }
        public ICommand ClearCommand { get; set; }
        public ICommand UpdateCommand { get; set; }


        public CustomerViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Customer = new CustomerDto();
            CustomerTypes = new ObservableCollection<CustomerTypeDto>();

            var clientTypes = Task.Factory.StartNew(() => ServicesInit.CRMService.GetCustomerTypesAsync());
            CustomerTypes = new ObservableCollection<CustomerTypeDto>(clientTypes.Result.Result);
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            AddOrUpdateCommand = new RelayCommand(() =>
            {
                ServicesInit.CRMService.AddCustomerAsync(Customer);
                _navigationService.NavigateTo("LinePage");
            });
            UpdateCommand = new RelayCommand(() => { ServicesInit.CRMService.UpdateCustomerAsync(Customer); });
            ClearCommand = new RelayCommand(() => Customer = null);
        }
    }
}

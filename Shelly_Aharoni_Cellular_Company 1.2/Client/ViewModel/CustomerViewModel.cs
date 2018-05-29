using Client.CRMServiceReference;
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
   public class CustomerViewModel:ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public CustomerDto Customer { get; set; }
        public int CustomerId { get; set; }

        public ObservableCollection<int> CustomerIds { get; set; }
        public ObservableCollection<CustomerTypeDto> CustomerTypes { get; set; }

        public ICommand AddOrUpdateCommand { get; set; }
        public ICommand ClearCommand { get; set; }
        public ICommand UpdateCommand { get; set; }

        private readonly CRMServiceClient CRMService;

        public CustomerViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            CRMService = new CRMServiceClient();
            Customer = new CustomerDto();
            CustomerTypes = new ObservableCollection<CustomerTypeDto>();

            var clientTypes = Task.Factory.StartNew(() => CRMService.GetCustomerTypesAsync());
            CustomerTypes = new ObservableCollection<CustomerTypeDto>(clientTypes.Result.Result);
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            AddOrUpdateCommand = new RelayCommand(() => { CRMService.AddCustomerAsync(Customer); });
            UpdateCommand = new RelayCommand(() => { CRMService.UpdateCustomerAsync(Customer); });
            ClearCommand = new RelayCommand(() => Customer = null);
        }
    }
}

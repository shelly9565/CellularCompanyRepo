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

        private readonly CRMServiceClient CRMService;

        public CustomerViewModel(INavigationService navigationService)
        {
            CRMService = new CRMServiceClient();
            _navigationService = navigationService;
            Customer = new CustomerDto();
            CustomerTypes = new ObservableCollection<CustomerTypeDto>();

            //var clients = Task.Factory.StartNew(() => CRMService.GetCustomersIdsAsync());
            //CustomerIds = new ObservableCollection<int>(clients.Result.Result.ToList());

            var clientTypes = Task.Factory.StartNew(() => CRMService.GetCustomerTypesAsync());
            CustomerTypes = new ObservableCollection<CustomerTypeDto>(clientTypes.Result.Result);
            if (CustomerId == 0)
                AddOrUpdateCommand = new RelayCommand(() => CRMService.AddCustomerAsync(Customer));
            //else
                //AddOrUpdateCommand=new RelayCommand(()=>CRMService.UpdateCustomerAsync())
        }
    }
}

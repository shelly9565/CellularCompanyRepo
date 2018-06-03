using Client.CRMServiceReference;
using Common.Dtoes;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ViewModel
{
    public class OptimalPackageViewModel : ViewModelBase
    {
        //private readonly ILineService _lineService;
        private readonly INavigationService _navigationService;
        private CustomerDto _customer;
        public LineDto Line { get; set; }

        public ObservableCollection<CustomerDto> Customers { get; set; }
        public CustomObservableCollection<LineDto> Lines { get; set; }

        public CustomerDto Customer
        {
            get { return _customer; }
            set
            {
                try
                {
                    _customer = value;
                    Task.Factory.StartNew((Action)(() =>
                    {
                        var linesTask = _lineService.GetLines((int)this.Customer.CustomerId).Result;
                        this.Lines.Repopulate(linesTask);
                        //RaisePropertyChanged(nameof(Lines));
                    }));
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        public OptimalPackageViewModel(ILineService lineService, INavigationService navigationService)
        {
            _lineService = lineService;
            _navigationService = navigationService;
            Customer = new CustomerDto();
            Line = new LineDto();
            Customer = new ObservableCollection<CustomerDto>();
            Lines = new CustomObservableCollection<LineDto>();


            var customerTask = Task.Factory.StartNew(() => _lineService.GetClients());
            Customer = new ObservableCollection<CustomerDto>(customerTask.Result.Result);
            RaisePropertyChanged(nameof(Customer));
        }
    }
}

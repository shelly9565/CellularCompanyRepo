using Common.Dtoes;
using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Client.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<CustomerDto> customerDtos { get; set; }

        public MainViewModel()
        {
            CustomerServiceReference.CustomerServiceClient customerServiceClient = new CustomerServiceReference.CustomerServiceClient();

            IEnumerable<CustomerServiceReference.CustomerDto> l = customerServiceClient.GetCustomers().ToList();


            List<CustomerDto> v = l.Select(c => Transform(c)).ToList();
            //c.Add(new CustomerDto { LastName = "a" });
            //c.Add(new CustomerDto { LastName = "b" });
            //c.Add(new CustomerDto { LastName = "c" });
            customerDtos = new ObservableCollection<CustomerDto>(v);
            int a = 1 + 1;
        }

        public CustomerDto Transform(CustomerServiceReference.CustomerDto customer)
        {
            CustomerDto c = new CustomerDto();
            c.CustomerId = customer.CustomerId;
            c.Address = customer.Address;
            c.CallsToCenter = customer.CallsToCenter;
            c.ContactNumber = customer.ContactNumber;
            c.CustomerTypeId = customer.CustomerTypeId;
            c.FirstName = customer.FirstName;
            c.LastName = customer.LastName;
            //c.CustomerType = customer.CustomerType.ToDto();
            //if (c.Lines != null)
            //    c.Lines = customer.Lines.Select(line => line.ToDto()).ToList();
            return c;
        }
    }
}
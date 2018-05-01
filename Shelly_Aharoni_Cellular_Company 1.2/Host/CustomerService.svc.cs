using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using BL;
using Common.Dtoes;

namespace Host
{
    public class CustomerService : ICustomerService
    {
        private CustomerProvider customerProvider = new CustomerProvider();

        public async Task<IEnumerable<CustomerDto>> GetCustomers()
        {
            return await customerProvider.GetCustomers();
        }
    }
}

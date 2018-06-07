using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infra.Providers.Info
{
    public interface ICustomerProvider
    {
        Task<IEnumerable<CustomerDto>> GetAllCustomers();
        Task<CustomerDto> GetCustomer(int id);
        Task<CustomerDto> AddCustomer(CustomerDto customerDto);
        Task<CustomerDto> UpdateCustomer(int id, CustomerDto customerDto);
        Task<CustomerDto> RemoveCustomer(int id);
        //Task<IEnumerable<int>> GetCustomerIds();
    }
}

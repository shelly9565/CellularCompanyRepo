using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repos.Infra
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<CustomerDto>> GetCustomers();
        Task<CustomerDto> GetCustomer(int id);
        Task<CustomerDto> CreateCustomer(CustomerDto customerDto);
        Task<CustomerDto> UpdateCustomer(int id, CustomerDto customerDto);
        Task<CustomerDto> DeleteCustomer(int id);
    }
}

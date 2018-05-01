using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repos.Infra
{
    public interface ICustomerTypeRepository
    {
        Task<IEnumerable<CustomerTypeDto>> GetCustomerTypes();
        Task<CustomerTypeDto> GetCustomerType(int id);
        Task<CustomerTypeDto> CreateCustomerType(CustomerTypeDto customerTypeDto);
        Task<CustomerTypeDto> UpdateCustomerType(int id, CustomerTypeDto customerTypeDto);
        Task<CustomerTypeDto> DeleteCustomerType(int id);
    }

}

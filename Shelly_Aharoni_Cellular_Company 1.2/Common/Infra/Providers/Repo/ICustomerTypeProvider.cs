using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infra.Providers.Repo
{
    public interface ICustomerTypeProvider
    {
        Task<IEnumerable<CustomerTypeDto>> GetAllCustomerTypes();
        Task<CustomerTypeDto> GetCustomerType(int id);
        Task<CustomerTypeDto> AddCustomerType(CustomerTypeDto customerTypeDto);
        Task<CustomerTypeDto> UpdateCustomerType(int id, CustomerTypeDto customerTypeDto);
        Task<CustomerTypeDto> RemoveCustomerType(int id);

    }
}

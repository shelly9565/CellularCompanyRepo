using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infra.Providers.Info
{
    public interface ICustomerTypeProvider
    {
        IEnumerable<CustomerTypeDto> GetAllCustomerTypes();
        Task<CustomerTypeDto> GetCustomerType(int id);
    }
}

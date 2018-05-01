using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        Task<IEnumerable<CustomerDto>> GetCustomers();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server.Infra
{
    [ServiceContract]
    public interface IReportsEngineService
    {
        [OperationContract]
        Task<IEnumerable<string>> MostValuableCustomers();
        [OperationContract]
        Task<IEnumerable<string>> MostCallingToCenterCustomers();

    }
}

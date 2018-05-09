using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CommonCommon.Infra.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICRMService" in both code and config file together.
    [ServiceContract]
    public interface ICRMService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        Task<bool> AddFullLine(LineDto line, PackageIncludeDto packageInclude, SelectedNumberDto selectedNumber, CustomerDto customer);
    }

}

using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server.ServicesInfra
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICRMService" in both code and config file together.
    [ServiceContract]
    public interface ICRMService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        Task<bool> AddFullLine(LineDto line, PackageIncludeDto packageInclude, SelectedNumberDto selectedNumber, CustomerDto customer);
        [OperationContract]
        Task<CustomerDto> AddCustomer(CustomerDto customer);
        [OperationContract]
        Task<CustomerDto> RemoveCustomer(int id);
        [OperationContract]
        Task<LineDto> RemoveLine(int id);

        [OperationContract]
        Task<CustomerDto> UpdateCustomer(CustomerDto customer);
        [OperationContract]
        Task<LineDto> UpdateLine(int lineId, LineDto line);
        [OperationContract]
        Task<IEnumerable<string>> GetSelectedNumbers(int lineId);
        [OperationContract]
        Task<IEnumerable<CustomerDto>> GetAllCustomers();
        [OperationContract]
        IEnumerable<int> GetCustomersIds();
        [OperationContract]
        Task<IEnumerable<CustomerTypeDto>> GetCustomerTypes();
        [OperationContract]
        //IEnumerable<LineDto> GetLines();
        Task<IEnumerable<PackageDto>> GetPackages();
        [OperationContract]
        IEnumerable<LineDto> GetLineForCustomer(int customerId);
    }
}

using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server.Infra
{
    [ServiceContract]
    public interface ICRMService
    {
        [OperationContract]
        Task<CustomerDto> AddCustomer(CustomerDto customer);
        [OperationContract]
        Task<bool> AddFullLine(LineDto line, PackageIncludeDto packageInclude, SelectedNumberDto selectedNumber, CustomerDto customer);
        [OperationContract]
        Task<IEnumerable<CustomerDto>> GetAllCustomers();
        [OperationContract]
        IEnumerable<int> GetCustomersIds();
        [OperationContract]
        Task<IEnumerable<CustomerTypeDto>> GetCustomerTypes();
        [OperationContract]
        IEnumerable<LineDto> GetLineForCustomer(int customerId);
        [OperationContract]
        Task<IEnumerable<PackageDto>> GetPackages();
        [OperationContract]
        Task<IEnumerable<string>> GetSelectedNumbers(int lineId);
        [OperationContract]
        Task<CustomerDto> RemoveCustomer(int id);
        [OperationContract]
        Task<LineDto> RemoveLine(int id);
        [OperationContract]
        Task<CustomerDto> UpdateCustomer(CustomerDto customer);
        [OperationContract]
        Task<LineDto> UpdateLine(int lineId, LineDto line);
    }
}

using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infra.Providers.BL
{
    public interface ICRMProvider
    {
        Task<bool> AddFullLine(LineDto line, PackageIncludeDto packageInclude, SelectedNumberDto selectedNumber, CustomerDto customer);
        Task<CustomerDto> AddCustomer(CustomerDto customer);

        Task<CustomerDto> RemoveCustomer(int id);
        Task<LineDto> RemoveLine(int id);

        Task<CustomerDto> UpdateCustomer(CustomerDto customer);
        Task<LineDto> UpdateLine(int lineId, LineDto line);
        Task<IEnumerable<string>> GetSelectedNumbers(int lineId);
        Task<IEnumerable<CustomerDto>> GetAllCustomers();
        IEnumerable<int> GetCustomersIds();
        IEnumerable<CustomerTypeDto> GetCustomerTypes();
        //IEnumerable<LineDto> GetLines();
        Task<IEnumerable<PackageDto>> GetPackages();
        IEnumerable<LineDto> GetLineForCustomer(int customerId);
    }
}

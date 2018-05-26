using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using BL.Providers.Logic;
using Common.Dtoes;
using Common.Infra.Providers.BL;
using Server.ServicesInfra;

namespace Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class CRMService : ICRMService
    {
        private readonly ICRMProvider _CRMProvider;

        public CRMService(ICRMProvider CRMProvider)
        {
            _CRMProvider = CRMProvider;
        }

        public async Task<CustomerDto> AddCustomer(CustomerDto customer)
        {
            return await _CRMProvider.AddCustomer(customer);
        }

        public async Task<bool> AddFullLine(LineDto line, PackageIncludeDto packageInclude, SelectedNumberDto selectedNumber, CustomerDto customer)
        {
            return await _CRMProvider.AddFullLine(line, packageInclude, selectedNumber, customer);
        }

        public async Task<IEnumerable<CustomerDto>> GetAllCustomers()
        {
            return await _CRMProvider.GetAllCustomers();
        }
        public IEnumerable<int> GetCustomersIds()
        {
            return _CRMProvider.GetCustomersIds();
        }
        public async Task<IEnumerable<CustomerTypeDto>> GetCustomerTypes()
        {
            var task=Task.Factory.StartNew(()=>
            {
                return _CRMProvider.GetCustomerTypes();
            });
            return await task.ConfigureAwait(false);
        }
        public IEnumerable<LineDto> GetLineForCustomer(int customerId)
        {
            return _CRMProvider.GetLineForCustomer(customerId);
        }
        public async Task<IEnumerable<PackageDto>> GetPackages()
        {
            return await _CRMProvider.GetPackages();
        }
        public async Task<IEnumerable<string>> GetSelectedNumbers(int lineId)
        {
            return await _CRMProvider.GetSelectedNumbers(lineId);
        }
        public async Task<CustomerDto> RemoveCustomer(int id)
        {
            return await _CRMProvider.RemoveCustomer(id);
        }
        public async Task<LineDto> RemoveLine(int id)
        {
            return await _CRMProvider.RemoveLine(id);
        }

        public async Task<CustomerDto> UpdateCustomer(CustomerDto customer)
        {
            return await _CRMProvider.UpdateCustomer(customer);
        }

        public async Task<LineDto> UpdateLine(int lineId, LineDto line)
        {
            return await _CRMProvider.UpdateLine(lineId, line);
        }
    }
}

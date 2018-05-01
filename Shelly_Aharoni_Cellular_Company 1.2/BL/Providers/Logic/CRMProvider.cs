using Autofac;
using Common.Dtoes;
using Common.Repos.Infra;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Providers.Logic
{
    public class CRMProvider
    {
        private Object _obj;

        public CRMProvider()
        {
            _obj = new Object();
        }

        private IContainer GetContainer()
        {
            return ModulesRegistrations.RegisterCRMModule();
        }

        public async Task<CustomerDto> AddCustomer(CustomerDto customer)
        {
            Task<CustomerDto> customerDto;
            lock (_obj)
            {
                ICustomerRepository customerRepository = GetContainer().Resolve<ICustomerRepository>();
                customerDto = customerRepository.CreateCustomer(customer);
            }
            return await customerDto;
        }

        public async Task<CustomerDto> RemoveCustomer(int id)
        {
            Task<CustomerDto> isDeleted;
            lock (_obj)
            {
                ICustomerRepository customerRepository = GetContainer().Resolve<ICustomerRepository>();
                isDeleted = customerRepository.DeleteCustomer(id);
            }
            return await isDeleted;
        }

        public async Task<CustomerDto> UpdateCustomer(CustomerDto customer)
        {
            Task<CustomerDto> customerDto;
            lock (_obj)
            {
                ICustomerRepository clientRepository = GetContainer().Resolve<ICustomerRepository>();
                customerDto = clientRepository.UpdateCustomer(customer.CustomerId, customer);
            }
            return await customerDto;
        }

        public async Task<PackageDto> UpdatePackage(string clientId, int lineId, PackageDto package)
        {
            Task<PackageDto> packageDto;
            lock (_obj)
            {
                IPackageRepository packageRepository = GetContainer().Resolve<IPackageRepository>();
                packageDto = packageRepository.UpdatePackage(package, lineId, clientId);
            }
            return await packageDto;
        }

        public async Task<CustomerDto> UpdateCustomerType(int typeId, CustomerDto client)
        {
            Task<CustomerDto> customerDto;
            lock (_obj)
            {
                ICustomerRepository clientRepository = GetContainer().Resolve<ICustomerRepository>();
                customerDto = clientRepository.UpdateClientClientType(client, typeId);
            }
            return await customerDto;
        }

        public IEnumerable<CustomerTypeDto> GetCustomerTypes()
        {
            try
            {
                List<CustomerTypeDto> clientTypeDto;
                lock (_obj)
                {
                    ICustomerTypeRepository clientTypeRepository = GetContainer().Resolve<ICustomerTypeRepository>();
                    clientTypeDto = clientTypeRepository.AddOrUpdateClientType().Result;
                    var a = clientTypeDto;
                }
                return clientTypeDto;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return null;
        }
    }
}

using Autofac;
using BL.Registrations;
using Common.Dtoes;
using Common.Infra.Providers.Info;
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
        private readonly ICustomerProvider _customerProvider;
        private readonly IPackageProvider _packageProvider;
        private readonly ICustomerTypeProvider _customerTypeProvider;
        private readonly ILineProvider _lineProvider;
        private readonly IPackageIncludeProvider _packageIncludeProvider;
        private readonly ISelectedNumberProvider _selectedNumberProvider;

        public CRMProvider()
        {
            _obj = new Object();
            _customerProvider = ModulesRegistrations.RegisterCRMModule().Resolve<ICustomerProvider>();
            _packageProvider = ModulesRegistrations.RegisterCRMModule().Resolve<IPackageProvider>();
            _customerTypeProvider = ModulesRegistrations.RegisterCRMModule().Resolve<ICustomerTypeProvider>();
            _lineProvider = ModulesRegistrations.RegisterCRMModule().Resolve<ILineProvider>();
            _packageIncludeProvider = ModulesRegistrations.RegisterCRMModule().Resolve<IPackageIncludeProvider>();
            _selectedNumberProvider = ModulesRegistrations.RegisterCRMModule().Resolve<ISelectedNumberProvider>();
        }

        public async Task<CustomerDto> AddCustomer(CustomerDto newCustomer)
        { 
            // must choose customer type, in order to add new customer
            if (newCustomer.CustomerTypeId == 0 || newCustomer == null) return null;
            else
            {
                Task<CustomerDto> customerDto;
                lock (_obj)
                {
                    customerDto = _customerProvider.AddCustomer(newCustomer);
                }
                return await customerDto;
            }
        }

        public async Task<CustomerDto> RemoveCustomer(int id)
        {
            Task<CustomerDto> customerToDel;
            lock (_obj)
            {
                customerToDel = _customerProvider.RemoveCustomer(id);
            }
            return await customerToDel;
        }

        public async Task<CustomerDto> UpdateCustomer(CustomerDto customer)
        {
            Task<CustomerDto> customerToUpdate;
            lock (_obj)
            {
                customerToUpdate = _customerProvider.UpdateCustomer(customer.CustomerId, customer);
            }
            return await customerToUpdate;
        }

        public async Task<LineDto> AddLine(LineDto newLine)
        {
            Task<LineDto> lineDto;
            lock (_obj)
            {
                lineDto = _lineProvider.AddLine(newLine);
            }
            return await lineDto;
        }

        public async Task<PackageDto> AddPackage(PackageDto newPackage)
        {
            Task<PackageDto> packageDto;
            lock (_obj)
            {
                packageDto = _packageProvider.AddPackage(newPackage);
            }
            return await packageDto;
        }

        public async Task<bool> AddSubscription(CustomerDto customer, LineDto line, PackageDto package)
        {
            Task<LineDto> lineDto = AddLine(line);
            Task<CustomerDto> customerDto = AddCustomer(customer);
            Task<PackageDto> packageDto = AddPackage(package);
            if (lineDto == null || packageDto == null || customerDto == null) return false;
            else return true;
        }
        public async Task<bool> AddFullLine( LineDto line, PackageIncludeDto packageInclude, SelectedNumberDto selectedNumber, CustomerDto customer)
        {
            return true;
        }
        public async Task<PackageDto> UpdatePackage(string clientId, int lineId, PackageDto package)
        {
            Task<PackageDto> packageToUpdate;
            lock (_obj)
            {
                packageToUpdate = _packageProvider.UpdatePackage(package.PackageId, package);
            }
            return await packageToUpdate;
        }

        public async Task<IEnumerable<CustomerDto>> GetAllCustomers()
        {
            Task<IEnumerable<CustomerDto>> customers;
            lock (_obj)
            {
                customers = _customerProvider.GetAllCustomers();
            }
            return await customers;
        }

        public async Task<CustomerDto> GetCustomer(int id)
        {
            Task<CustomerDto> customer;
            lock (_obj)
            {
                customer = _customerProvider.GetCustomer(id);
            }
            return await customer;
        }


        public async Task<CustomerTypeDto> UpdateCustomerType(int typeId, CustomerDto customer)
        {
            Task<CustomerTypeDto> custmrTypeToUpdate;
            lock (_obj)
            {
                custmrTypeToUpdate = _customerTypeProvider.UpdateCustomerType(customer.CustomerTypeId, customer.CustomerType);

            }
            return await custmrTypeToUpdate;
        }

        public async Task<IEnumerable<CustomerTypeDto>> GetCustomerTypes()
        {
            try
            {
                IEnumerable<CustomerTypeDto> customerTypes;
                lock (_obj)
                {
                    customerTypes = _customerTypeProvider.GetAllCustomerTypes().Result;
                }
                return customerTypes;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return null;
        }
    }
}

using Autofac;
using BL.Registrations;
using Common.Dtoes;
using Common.Infra.Providers.BL;
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
    public class CRMProvider : ICRMProvider
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
            if (newCustomer == null) return null;
            // must choose customer type, in order to add new customer
            else
            {
                newCustomer.CustomerTypeId = newCustomer.CustomerType.CustomerTypeId;
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

        public async Task<bool> AddFullLine(LineDto line, PackageIncludeDto packageInclude, SelectedNumberDto selectedNumber, CustomerDto customer)
        {
            lock (_obj)
            {
                LineDto newLine = _lineProvider.AddLine(line).Result;
                PackageIncludeDto newPackageInclude = _packageIncludeProvider.AddPackageInclude(packageInclude).Result;
                CustomerDto newCustomer = _customerProvider.AddCustomer(customer).Result;
                SelectedNumberDto newSelectedNumber = _selectedNumberProvider.AddSelectedNumber(selectedNumber).Result;
                newPackageInclude.Line = newLine;
                line.Customer = newCustomer;
                line.CustomerId = newCustomer.CustomerId;
                packageInclude.SelectedNumber = newSelectedNumber;
                line.PackageInclude = newPackageInclude;
                return true;
            }
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

        public IEnumerable<CustomerTypeDto> GetCustomerTypes()
        {
            try
            {
                lock (_obj)
                {
                    return _customerTypeProvider.GetAllCustomerTypes();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return null;
        }


        public async Task<LineDto> RemoveLine(int id)
        {
            Task<LineDto> line;
            lock (_obj)
            {
                line = _lineProvider.RemoveLine(id);
            }
            return await line;
        }

        public async Task<CustomerDto> UpdateCustomer(int customerId, CustomerDto customer)
        {
            Task<CustomerDto> customerDto;
            lock (_obj)
            {
                customerDto = _customerProvider.UpdateCustomer(customerId, customer);
            }
            return await customerDto;
        }

        public async Task<LineDto> UpdateLine(int lineId, LineDto line)
        {
            Task<LineDto> lineDto;
            lock (_obj)
            {
                lineDto = _lineProvider.UpdateLine(lineId, line);
            }
            return await lineDto;
        }

        public async Task<IEnumerable<string>> GetSelectedNumbers(int lineId)
        {
            Task<IEnumerable<string>> list;
            lock (_obj)
            {
                list = _selectedNumberProvider.GetSelectedNumbersByLine(lineId);
            }
            return await list;
        }

        public IEnumerable<int> GetCustomersIds()
        {
            List<int> list;
            lock (_obj)
            {
                IEnumerable<CustomerDto> l = _customerProvider.GetAllCustomers().Result;
                list = l.Select(c => c.CustomerId).ToList();
            }
            return list;
        }

        public async Task<IEnumerable<PackageDto>> GetPackages()
        {
            Task<IEnumerable<PackageDto>> packages;
            lock (_obj)
            {
                packages = _packageProvider.GetAllPackages();
            }
            return await packages;
        }

        public IEnumerable<LineDto> GetLineForCustomer(int customerId)
        {
            IEnumerable<LineDto> lines;
            lock (_obj)
            {
                lines = _lineProvider.GetAllLines().Result.Where(l => l.CustomerId == customerId).ToList();
            }
            return lines;
        }
    }
}

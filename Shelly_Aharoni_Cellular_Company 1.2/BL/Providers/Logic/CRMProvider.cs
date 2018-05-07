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
        private readonly IPaymentProvider _paymentProvider;
        private readonly IPackageProvider _packageProvider;
        private readonly ICustomerTypeProvider _customerTypeProvider;
        private readonly ILineProvider _lineProvider;
        private readonly IPackageIncludeProvider _packageIncludeProvider;
        private readonly ISelectedNumberProvider _selectedNumberProvider;

        public CRMProvider()
        {
            _obj = new Object();
            _customerProvider = GetContainer().Resolve<ICustomerProvider>();
            _paymentProvider = GetContainer().Resolve<IPaymentProvider>();
            _packageProvider = GetContainer().Resolve<IPackageProvider>();
            _customerTypeProvider = GetContainer().Resolve<ICustomerTypeProvider>();
            _lineProvider = GetContainer().Resolve<ILineProvider>();
            _packageIncludeProvider = GetContainer().Resolve<IPackageIncludeProvider>();
            _selectedNumberProvider = GetContainer().Resolve<ISelectedNumberProvider>();
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
                ICustomerProvider customerProvider = GetContainer().Resolve<ICustomerProvider>();
                customerDto = customerProvider.AddCustomer(customer);
            }
            return await customerDto;
        }

        public async Task<CustomerDto> RemoveCustomer(int id)
        {
            Task<CustomerDto> customerToDel;
            lock (_obj)
            {
                ICustomerProvider customerProvider = GetContainer().Resolve<ICustomerProvider>();
                customerToDel = customerProvider.RemoveCustomer(id);
            }
            return await customerToDel;
        }

        public async Task<CustomerDto> UpdateCustomer(CustomerDto customer)
        {
            Task<CustomerDto> customerToUpdate;
            lock (_obj)
            {
                ICustomerProvider customerProvider = GetContainer().Resolve<ICustomerProvider>();
                customerToUpdate = customerProvider.UpdateCustomer(customer.CustomerId, customer);
            }
            return await customerToUpdate;
        }

        public async Task<LineDto> AddLine(LineDto line)
        {
            Task<LineDto> lineDto;
            lock (_obj)
            {
                lineDto = _lineProvider.AddLine(line);
            }
            return await lineDto;
        }
 
        //???????????????????????????????????????????????????????????????????????
        public async Task<PackageDto> UpdatePackage(string clientId, int lineId, PackageDto package)
        {
            Task<PackageDto> packageToUpdate;
            lock (_obj)
            {
                IPackageProvider packageProvider = GetContainer().Resolve<IPackageProvider>();
                packageToUpdate = packageProvider.UpdatePackage(package.PackageId, package);
            }
            return await packageToUpdate;
        }

        public async Task<IEnumerable<CustomerDto>> GetAllCustomers()
        {
            Task<IEnumerable<CustomerDto>> customers;
            lock (_obj)
            {
                ICustomerProvider customerProvider = GetContainer().Resolve<ICustomerProvider>();
                customers = customerProvider.GetAllCustomers();
            }
            return await customers;
        }

        public async Task<CustomerDto> GetCustomer(int id)
        {
            Task<CustomerDto> customer;
            lock (_obj)
            {
                ICustomerProvider customerProvider = GetContainer().Resolve<ICustomerProvider>();
                customer = customerProvider.GetCustomer(id);
            }
            return await customer;
        }


        public async Task<CustomerTypeDto> UpdateCustomerType(int typeId, CustomerDto customer)
        {
            Task<CustomerTypeDto> custmrTypeToUpdate;
            lock (_obj)
            {
                ICustomerTypeProvider customerTypeProvider = GetContainer().Resolve<ICustomerTypeProvider>();
                custmrTypeToUpdate = customerTypeProvider.UpdateCustomerType(customer.CustomerTypeId, customer.CustomerType);

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
                    ICustomerTypeProvider customerTypeProvider = GetContainer().Resolve<ICustomerTypeProvider>();
                    customerTypes = customerTypeProvider.GetAllCustomerTypes().Result;
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

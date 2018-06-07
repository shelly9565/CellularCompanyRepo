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
        private readonly ISmsProvider _smsProvider;
        private readonly ICallProvider _callProvider;

        public CRMProvider()
        {
            _obj = new Object();
            _customerProvider = ModulesRegistrations.RegisterCRMModule().Resolve<ICustomerProvider>();
            _packageProvider = ModulesRegistrations.RegisterCRMModule().Resolve<IPackageProvider>();
            _customerTypeProvider = ModulesRegistrations.RegisterCRMModule().Resolve<ICustomerTypeProvider>();
            _lineProvider = ModulesRegistrations.RegisterCRMModule().Resolve<ILineProvider>();
            _packageIncludeProvider = ModulesRegistrations.RegisterCRMModule().Resolve<IPackageIncludeProvider>();
            _selectedNumberProvider = ModulesRegistrations.RegisterCRMModule().Resolve<ISelectedNumberProvider>();
            _smsProvider = ModulesRegistrations.RegisterCRMModule().Resolve<ISmsProvider>();
            _callProvider = ModulesRegistrations.RegisterCRMModule().Resolve<ICallProvider>();
            
        }

        public async Task<CustomerDto> AddCustomer(CustomerDto newCustomer)
        {
            if (newCustomer == null) return null;
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

        public async Task<LineDto> AddLine(LineDto newLine, SelectedNumberDto newSelectedNumber)
        {
            Task<LineDto> lineDto;
            lock (_obj)
            {
                lineDto = _lineProvider.AddLine(newLine, newSelectedNumber);
            }
            return await lineDto;
        }

        public async Task<PackageDto> UpdatePackage(int clientId, int lineId, PackageDto package)
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

        public IEnumerable<LineDto> GetLinesForCustomer(int customerId)
        {
            IEnumerable<LineDto> lines;
            lock (_obj)
            {
                lines = _lineProvider.GetAllLines().Result.Where(l => l.CustomerId == customerId).ToList();
            }
            return lines;
        }

        public IEnumerable<CallDto> GetCallsForCustomer(int customerId)
        {
            lock (_obj)
            {
                IEnumerable<LineDto> linesForCustomer = _lineProvider.GetAllLines().Result.Where(l => l.CustomerId == customerId).ToList();
                List<CallDto> calls = new List<CallDto>();
                foreach (var line in linesForCustomer)
                {
                    var callsForLine = _callProvider.GetAllCalls().Result.Where(s => s.LineId == line.LineId).ToList();
                    calls.AddRange(callsForLine);
                }
            return calls;
            }
        }

        public IEnumerable<SMSDto> GetSmsesForCustomer(int customerId)
        {
            lock (_obj)
            {
                IEnumerable<LineDto> linesForCustomer = _lineProvider.GetAllLines().Result.Where(l => l.CustomerId == customerId).ToList();
                List<SMSDto> smses = new List<SMSDto>();
                foreach (var line in linesForCustomer)
                {
                    var smsesForLine = _smsProvider.GetAllSMSes().Result.Where(s => s.LineId == line.LineId).ToList();
                    smses.AddRange(smsesForLine);
                }
                return smses;
            }
        }

        public IEnumerable<PackageDto> GetPackageForCustomer(int customerId)
        {
            lock (_obj)
            {
                IEnumerable<LineDto> linesForCustomer = _lineProvider.GetAllLines().Result.Where(l => l.CustomerId == customerId).ToList();
                List<PackageDto> packages = new List<PackageDto>();
                foreach (var line in linesForCustomer)
                {
                    packages.Add(line.Package);
                }
                return packages;
            }
        }
    }
}

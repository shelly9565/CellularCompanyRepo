using Autofac;
using BL.Registrations;
using Common.Dtoes;
using Common.Infra.Providers.BL;
using Common.Infra.Providers.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Providers.Logic
{
    public class ReportEngineProvider : IReportsEngineProvider
    {
        private readonly ICustomerTypeProvider _clientTypeManager;
        private readonly ISmsProvider _smsProvider;
        private readonly ICallProvider _callProvider;
        private readonly ICustomerProvider _customerProvider;
        private readonly IPackageProvider _packageProvider;
        private readonly ILineProvider _lineProvider;
        private readonly ICRMProvider _crmProvider;

        public ReportEngineProvider()
        {
            _clientTypeManager = GetContainer().Resolve<ICustomerTypeProvider>();
            _smsProvider = GetContainer().Resolve<ISmsProvider>();
            _callProvider = GetContainer().Resolve<ICallProvider>();
            _customerProvider = GetContainer().Resolve<ICustomerProvider>();
            _packageProvider = GetContainer().Resolve<IPackageProvider>();
            _lineProvider = GetContainer().Resolve<ILineProvider>();
        }

        public IContainer GetContainer()
        {
            return ModulesRegistrations.RegisterReportsEngine();
        }

        //public IEnumerable<LineDto> GetClientMostCalledNumbers(int customerId)
        //{
        //    Dictionary<string, int> dictionary = new Dictionary<string, int>();
        //    List<string> mostConnectedNumbers = _crmProvider.GetLineForCustomer(customerId).Select(s => s.DestinationNumber).ToList();
        //    mostConnectedNumbers.AddRange(_crmProvider.GetCallsForCustomer(customerId).Select(s => s.DestinationNumber).ToList());
        //    foreach (var i in mostConnectedNumbers)
        //    {
        //        if (!dictionary.Keys.Contains(i))
        //            dictionary.Add(i, 1);
        //        else
        //            dictionary[i]++;
        //    }
        //    List<string> list = dictionary.Keys.Take(3).ToList();
        //    List<LineDto> lines = new List<LineDto>();
        //    foreach (var i in list)
        //    {
        //        if (_lineProvider.GetLineByNumber(i) != null)
        //        {
        //            LineDto line = _lineProvider.GetLineByNumber(i);
        //            lines.Add(line);
        //        }
        //    }
        //    return lines;
        //}

        public IEnumerable<string> MostCallingToCenterClients()
        {
            List<CustomerDto> list = _customerProvider.GetAllCustomers().Result.ToList();
            var clients = (from c in list
                           orderby c.CallsToCenter descending
                           select ($"{c.FirstName} {c.LastName} called to center {c.CallsToCenter} times")).Take(3);
            return clients;
        }

        public IEnumerable<string> MostValuableClients()
        {
            Dictionary<CustomerDto, double> dictionary = new Dictionary<CustomerDto, double>();
            foreach (var item in _customerProvider.GetAllCustomers().Result)
            {
                CustomerTypeDto customerTypeDto = _customerProvider.GetCustomer(item.CustomerId).Result.CustomerType;
                double value = GetCallsPrice(item, customerTypeDto) + GetPackageIncludesPrice(item) + GetPackagePrice(item) + GetSmsPrice(item, customerTypeDto);
                dictionary.Add(item, value);
            }
            var sortedDictionary = from v in dictionary
                                   orderby v.Value descending
                                   select v;
            List<string> list = new List<string>();
            foreach (var item in sortedDictionary)
            {
                list.Add($"{item.Key.FirstName} {item.Key.LastName} has a value of {item.Value}");
            }
            return list.Take(3);
        }

        public double GetPackagePrice(CustomerDto item)
        {
            List<int> packageIds = _crmProvider.GetLinesForCustomer(item.CustomerId).Select(p => p.PackageId).ToList();
            double totalLinesPackagesPrice = 0;
            if (packageIds != null)
            {
                foreach (var id in packageIds)
                {
                    totalLinesPackagesPrice += _packageProvider.GetPackage(id).Result.PackageTotalPrice;
                }
            }
            return totalLinesPackagesPrice;
        }

        public double GetPackageIncludesPrice(CustomerDto customer)
        {
            double totalPackageIncludesPrice = 0;
            List<PackageDto> packages = _crmProvider.GetPackageForCustomer(customer.CustomerId).ToList();
            if (packages != null)
            {
                List<PackageIncludeDto> packagesIncludes = packages.Select(p => p.PackageIncludes).ToList();
                foreach (var p in packages)
                {
                    foreach (var pi in p.PackageIncludes)
                    {
                        totalPackageIncludesPrice += (pi.FixedPrice * pi.DiscountPrecentage);
                    }
                }
            }
            return totalPackageIncludesPrice;

        }
        

    public double GetSmsPrice(CustomerDto customer, CustomerTypeDto customerTypeDto)
        {
            double smsPrice = customerTypeDto.SMSPrice;
            List<SMSDto> smsDto = _crmProvider.GetSmsesForCustomer(customer.CustomerId).Where(s => s.SmsSendTime.Month == DateTime.Now.Month).ToList();
            if (smsDto != null)
                return smsDto.Count * smsPrice;
            return 0;
        }

        public double GetCallsPrice(CustomerDto customer, CustomerTypeDto customerTypeDto)
        {
            double callPrice = customerTypeDto.MinutePrice;
            List<CallDto> callDto = _crmProvider.GetCallsForCustomer(customer.CustomerId).Where(c => c.callSendDate.Month == DateTime.Now.Month).ToList();
            if (callDto != null)
                return callDto.Count * callPrice;
            return 0;
        }
    }
}

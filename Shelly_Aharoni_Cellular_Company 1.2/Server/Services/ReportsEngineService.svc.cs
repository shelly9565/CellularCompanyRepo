using Common.Infra.Providers.BL;
using Server.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    public class ReportsEngineService : IReportsEngineService
    {
        private readonly IReportsEngineProvider _reportsEngineProvider;
        public ReportsEngineService(IReportsEngineProvider reportsEngineProvider)
        {
            _reportsEngineProvider = reportsEngineProvider;
        }

        public async Task<IEnumerable<string>> MostValuableCustomers()
        {
            var task = Task.Factory.StartNew(() =>
            {
                var a = _reportsEngineProvider.MostValuableCustomers();
                return a;
            });
            return await task.ConfigureAwait(false);
        }

        public async Task<IEnumerable<string>> MostCallingToCenterCustomers()
        {
            var task = Task.Factory.StartNew(() =>
            {
                var a = _reportsEngineProvider.MostCallingToCenterClients();
                return a;
            });
            return await task.ConfigureAwait(false);
        }

        //public StringBuilder GetGroups()
        //{
        //    return _reportsEngineManager.GetGroups();
        //}
    }
}

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
using Server.Services;

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

        public Task<bool> AddFullLine(LineDto line, PackageIncludeDto packageInclude, SelectedNumberDto selectedNumber, CustomerDto customer)
        {
            return _CRMProvider.AddFullLine(line, packageInclude, selectedNumber, customer);
        }

        public void DoWork()
        {
        }
    }
}

using Autofac;
using BL.Registrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Providers.Logic
{
    public class OptimalPackageProvider
    {
        private IContainer GetContainer()
        {
            return ModulesRegistrations.RegisterOptimalPackageModule();
        }

        public void FindOptimalPackage()
        {

        }
    }
}

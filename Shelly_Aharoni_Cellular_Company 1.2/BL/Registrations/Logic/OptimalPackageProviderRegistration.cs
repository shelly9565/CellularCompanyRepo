using Autofac;
using BL.Providers.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Registrations.Logic
{
   public class OptimalPackageProviderRegistration :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OptimalPackageProvider>()
                .As<IOptimalPackageProvider>()
                .SingleInstance();
            base.Load(builder);
        }

    }
}

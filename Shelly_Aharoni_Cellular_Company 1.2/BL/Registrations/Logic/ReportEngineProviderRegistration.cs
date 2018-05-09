using Autofac;
using BL.Providers.Logic;
using Common.Infra.Providers.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Registrations.Logic
{
   public class ReportEngineProviderRegistration :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ReportEngineProvider>()
                .As<IReportEngineProvider>()
                .SingleInstance();
            base.Load(builder);
        }

    }
}

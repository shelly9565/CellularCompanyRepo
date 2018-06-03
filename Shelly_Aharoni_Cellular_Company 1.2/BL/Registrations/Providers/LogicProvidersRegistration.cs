using Autofac;
using BL.Providers.Logic;
using Common.Infra.Providers.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Registrations.Providers.LogicProvidersRegistration
{
    //class LogicProvidersRegistration
    //{
    //}
    public class CRMProviderRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CRMProvider>()
                .As<ICRMProvider>()
                .SingleInstance();
            base.Load(builder);
        }
    }
    public class InvoiceProviderRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<InvoiceProvider>()
                .As<IInvoiceProvider>()
                .SingleInstance();
            base.Load(builder);
        }
    }
    public class OptimalPackageProviderRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OptimalPackageProvider>()
                .As<IOptimalPackageProvider>()
                .SingleInstance();
            base.Load(builder);
        }

    }
    public class ReportEngineProviderRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ReportEngineProvider>()
                .As<IReportsEngineProvider>()
                .SingleInstance();
            base.Load(builder);
        }

    }

}

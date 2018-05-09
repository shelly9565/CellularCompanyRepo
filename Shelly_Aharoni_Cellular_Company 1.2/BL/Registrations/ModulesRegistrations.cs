using Autofac;
using BL.Registrations.Providers;
using BL.Registrations.Providers.InfoProvidersRegistration;
using BL.Registrations.Providers.LogicProvidersRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Registrations
{
    public class ModulesRegistrations
    {
        public static IContainer RegisterCRMModule()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<ClientProviderRegistration>();
            builder.RegisterModule<LineProviderRegistration>();
            builder.RegisterModule<PackageProviderRegistration>();
            builder.RegisterModule<ClientTypeProviderRegistration>();
            builder.RegisterModule<PackageIncludesProviderRegistration>();
            builder.RegisterModule<SelectedNumbersProviderRegistration>();

            IContainer container = builder.Build();
            return container;
        }

        public static IContainer RegisterInvoiceModule()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<CRMProviderRegistration>();
            builder.RegisterModule<CallProviderRegistration>();
            builder.RegisterModule<SmsProviderRegistration>();
            builder.RegisterModule<PaymentProviderRegistration>();
            builder.RegisterModule<PackageIncludesProviderRegistration>();
            builder.RegisterModule<PackageProviderRegistration>();

            IContainer container = builder.Build();
            return container;
        }

        public static IContainer RegisterOptimalPackageModule()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<CRMProviderRegistration>();
            builder.RegisterModule<CallProviderRegistration>();
            builder.RegisterModule<SmsProviderRegistration>();
            builder.RegisterModule<LineProviderRegistration>();
            builder.RegisterModule<PackageIncludesProviderRegistration>();
            builder.RegisterModule<PackageProviderRegistration>();
            builder.RegisterModule<PaymentProviderRegistration>();
            builder.RegisterModule<ClientTypeProviderRegistration>();

            IContainer container = builder.Build();
            return container;
        }
    }
}

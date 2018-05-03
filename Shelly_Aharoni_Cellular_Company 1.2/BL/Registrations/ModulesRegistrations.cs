using Autofac;
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

            builder.RegisterModule<ClientManagerRegistration>();
            builder.RegisterModule<LineManagerRegistration>();
            builder.RegisterModule<PackageManagerRegistration>();
            builder.RegisterModule<ClientTypeManagerRegistration>();
            builder.RegisterModule<PackageIncludesManagerRegistration>();
            builder.RegisterModule<SelectedNumbersManagerRegistration>();

            IContainer container = builder.Build();
            return container;
        }

        public static IContainer RegisterInvoiceModule()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<CRMManagerRegistration>();
            builder.RegisterModule<CallManagerRegistration>();
            builder.RegisterModule<SMSManagerRegistration>();
            builder.RegisterModule<PaymentManagerRegistration>();
            builder.RegisterModule<PackageIncludesManagerRegistration>();
            builder.RegisterModule<PackageManagerRegistration>();

            IContainer container = builder.Build();
            return container;
        }

        public static IContainer RegisterOptimalPackageModule()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<CRMManagerRegistration>();
            builder.RegisterModule<CallManagerRegistration>();
            builder.RegisterModule<SMSManagerRegistration>();
            builder.RegisterModule<LineManagerRegistration>();
            builder.RegisterModule<PackageIncludesManagerRegistration>();
            builder.RegisterModule<PackageManagerRegistration>();
            builder.RegisterModule<PaymentManagerRegistration>();
            builder.RegisterModule<ClientTypeManagerRegistration>();

            IContainer container = builder.Build();
            return container;
        }
    }
}

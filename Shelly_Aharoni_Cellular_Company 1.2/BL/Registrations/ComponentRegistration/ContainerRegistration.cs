using Autofac;
using BL.Registrations.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Registrations.ComponentRegistration
{
    public class ContainerRegistration
    {
        public static IContainer RegisterCRMModule()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<CustomerRepoRegistration>();
            builder.RegisterModule<LineRepoRegistration>();
            builder.RegisterModule<PackageRepoRegistration>();
            builder.RegisterModule<CustomerTypeRepoRegistration>();

            IContainer container = builder.Build();
            return container;
        }

        public static IContainer RegisterInvoiceModule()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterModule<CRMManagerRegistration>();
            builder.RegisterModule<CallRepoRegistration>();
            builder.RegisterModule<SMSRepoRegistration>();
            builder.RegisterModule<PaymentRepoRegistration>();
            builder.RegisterModule<PackageIncludeRepoRegistration>();
            builder.RegisterModule<PackageRepoRegistration>();

            IContainer container = builder.Build();
            return container;
        }

        public static IContainer RegisterOptimalPackageModule()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterModule<CRMManagerRegistration>();
            //builder.RegisterModule<CallRepositoryRegistration>();
            //builder.RegisterModule<SMSRepositoryRegistration>();
            //builder.RegisterModule<LineRepositoryRegistration>();
            //builder.RegisterModule<PackageIncludesRepositoryRegistration>();
            //builder.RegisterModule<PackageRepositoryRegistration>();
            //builder.RegisterModule<PaymentRepositoryRegistration>();
            //builder.RegisterModule<ClientTypeRepositoryRegistration>();

            IContainer container = builder.Build();
            return container;
        }
    }
}

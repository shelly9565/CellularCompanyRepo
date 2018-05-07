using Autofac;
using BL.Providers.Info;
using Common.Infra.Providers.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Registrations.ProvidersRegistration
{
    //public class ProviderRegistrations
    //{
    //}

    public class CallProviderRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CallProvider>()
                .As<ICallProvider>()
                .SingleInstance();
            base.Load(builder);
        }
    }

    public class ClientProviderRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerProvider>()
                .As<ICustomerProvider>()
                .SingleInstance();
            base.Load(builder);
        }
    }
    public class ClientTypeProviderRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerTypeProvider>()
                .As<ICustomerTypeProvider>()
                .SingleInstance();
            base.Load(builder);
        }
    }
    public class LineProviderRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LineProvider>()
                .As<ILineProvider>()
                .SingleInstance();
            base.Load(builder);
        }
    }
    public class PackageIncludesProviderRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PackageIncludeProvider>()
                .As<IPackageIncludeProvider>()
                .SingleInstance();
            base.Load(builder);
        }
    }
    public class PackageProviderRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PackageProvider>()
                .As<IPackageProvider>()
                .SingleInstance();
            base.Load(builder);
        }
    }
    public class PaymentProviderRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PaymentProvider>()
                .As<IPaymentProvider>()
                .SingleInstance();
            base.Load(builder);
        }
    }
    public class SelectedNumbersProviderRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Providers.Info.SelectedNumberProvider>()
                .As<ISelectedNumberProvider>()
                .SingleInstance();
            base.Load(builder);
        }
    }
    public class SmsProviderRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SmsProvider>()
                .As<ISmsProvider>()
                .SingleInstance();
            base.Load(builder);
        }
    }


}

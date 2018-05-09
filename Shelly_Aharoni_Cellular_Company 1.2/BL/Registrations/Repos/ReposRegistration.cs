using Autofac;
using Common.Repos.Infra;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Registrations.Repos.ReposRegistration
{
    //class ReposRegistration
    //{
    //}

    public class CallRepoRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CallRepository>()
                   .As<ICallRepository>()
                   .SingleInstance();

            base.Load(builder);
        }
    }

    public class CustomerRepoRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerRepository>()
                   .As<ICustomerRepository>()
                   .SingleInstance();

            base.Load(builder);
        }
    }
    public class CustomerTypeRepoRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerTypeRepository>()
                   .As<ICustomerTypeRepository>()
                   .SingleInstance();

            base.Load(builder);
        }
    }
    public class LineRepoRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LineRepository>()
                   .As<ILineRepository>()
                   .SingleInstance();

            base.Load(builder);
        }
    }
    public class PackageIncludeRepoRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PackageIncludeRepository>()
                   .As<IPackageIncludeRepository>()
                   .SingleInstance();

            base.Load(builder);
        }
    }
    public class PackageRepoRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PackageRepository>()
                   .As<IPackageRepository>()
                   .SingleInstance();

            base.Load(builder);
        }
    }
    public class PaymentRepoRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PaymentRepository>()
                   .As<IPaymentRepository>()
                   .SingleInstance();

            base.Load(builder);
        }
    }
    public class SelectedNumberRepoRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SelectedNumberRepository>()
                   .As<ISelectedNumberRepository>()
                   .SingleInstance();

            base.Load(builder);
        }
    }
    public class SMSRepoRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SMSRepository>()
                   .As<ISMSRepository>()
                   .SingleInstance();

            base.Load(builder);
        }
    }


}

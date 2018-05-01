using Autofac;
using Common.Repos.Infra;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Registrations.Repo
{
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

}

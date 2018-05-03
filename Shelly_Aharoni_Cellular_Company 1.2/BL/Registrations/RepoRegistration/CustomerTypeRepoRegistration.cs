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

}

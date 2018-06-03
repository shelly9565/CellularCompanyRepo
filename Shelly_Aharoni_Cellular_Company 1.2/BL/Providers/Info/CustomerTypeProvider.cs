using Autofac;
using Common.Dtoes;
using Common.Infra.Providers.Info;
using Common.Repos.Infra;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Providers.Info
{
    public class CustomerTypeProvider : ICustomerTypeProvider
    {
        private static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CustomerTypeRepository>()
                    .As<ICustomerTypeRepository>()
                    .SingleInstance();
            return builder.Build();
        }
        

        public IEnumerable<CustomerTypeDto> GetAllCustomerTypes()
        {
            return GetContainer().Resolve<ICustomerTypeRepository>().GetCustomerTypes();
        }

        public Task<CustomerTypeDto> GetCustomerType(int id)
        {
            return GetContainer().Resolve<ICustomerTypeRepository>().GetCustomerType(id);
        }
        
    }
}

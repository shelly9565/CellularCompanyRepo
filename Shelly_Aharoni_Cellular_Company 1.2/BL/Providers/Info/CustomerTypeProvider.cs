using Autofac;
using Common.Dtoes;
using Common.Infra.Providers.Repo;
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

        public Task<CustomerTypeDto> AddCustomerType(CustomerTypeDto customerTypeDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CustomerTypeDto>> GetAllCustomerTypes()
        {
            return GetContainer().Resolve<ICustomerTypeRepository>().GetCustomerTypes();
        }

        public Task<CustomerTypeDto> GetCustomerType(int id)
        {
            return GetContainer().Resolve<ICustomerTypeRepository>().GetCustomerType(id);
        }

        public Task<CustomerTypeDto> RemoveCustomerType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerTypeDto> UpdateCustomerType(int id, CustomerTypeDto customerTypeDto)
        {
            throw new NotImplementedException();
        }
    }
}

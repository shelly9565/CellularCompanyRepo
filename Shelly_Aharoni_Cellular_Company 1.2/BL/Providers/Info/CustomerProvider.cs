﻿using Autofac;
using Common.Dtoes;
using Common.Infra.Providers.Info;
using Common.Repos.Infra;
using DAL;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Providers.Info
{
    public class CustomerProvider : ICustomerProvider
    {
        private static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CustomerRepository>()
                    .As<ICustomerRepository>()
                    .SingleInstance();
            return builder.Build();
        }

        public async Task<CustomerDto> AddCustomer(CustomerDto customerDto)
        {
            return await GetContainer().Resolve<ICustomerRepository>().CreateCustomer(customerDto);
        }

        public async Task<CustomerDto> RemoveCustomer(int customerId)
        {
            return await GetContainer().Resolve<ICustomerRepository>().DeleteCustomer(customerId);
        }

        public async Task<CustomerDto> UpdateCustomer(CustomerDto customerDto, int customerId)
        {
            return await GetContainer().Resolve<ICustomerRepository>().UpdateCustomer(customerId, customerDto);
        }

        public async Task<CustomerDto> GetCustomer(int customerId)
        {
            return await GetContainer().Resolve<ICustomerRepository>().GetCustomer(customerId);
        }

        public async Task<IEnumerable<CustomerDto>> GetAllCustomers()
        {
            try
            {
                return await GetContainer().Resolve<ICustomerRepository>().GetCustomers();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public Task<CustomerDto> UpdateCustomer(int id, CustomerDto customerDto)
        {
            throw new NotImplementedException();
        }

        //public async Task<IEnumerable<int>> GetCustomerIds()
        //{
        //    IEnumerable<CustomerDto> cstmrs =  await GetContainer().Resolve<ICustomerRepository>().GetCustomers();
        //    return cstmrs.Select(c => c.CustomerId).ToList();
        //}

    }

}

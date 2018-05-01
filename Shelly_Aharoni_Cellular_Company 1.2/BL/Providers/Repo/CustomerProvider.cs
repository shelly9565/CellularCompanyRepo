using Common.Dtoes;
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

namespace BL.Providers.Repo
{
    public class CustomerProvider
    {
        private ICustomerRepository _customerRepository = new CustomerRepository();

        //public CustomerProvider(CustomerRepository repository)
        //{
        //    _customerRepository = repository;
        //}

        public async Task<CustomerDto> GetCustomer(int id)
        {
            try
            {
                CustomerDto customerDto = await _customerRepository.GetCustomer(id);
                return customerDto;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.InnerException);
                return null;
            }
        }

        public async Task<IEnumerable<CustomerDto>> GetCustomers()
        {
            try
            {
                IEnumerable<CustomerDto> customers = await _customerRepository.GetCustomers();
                return customers.Select(custmer => custmer);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.InnerException);
                return null;
            }
        }

        public async Task<CustomerDto> PostCustomer(CustomerDto customer)
        {
            try
            {
                CustomerDto cstmrDto = await _customerRepository.CreateCustomer(customer);
                return cstmrDto;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.InnerException);
                return null;
            }
        }

        public async Task<CustomerDto> DeleteCustomer(int id)
        {
            try
            {
                CustomerDto cstmrDto = await _customerRepository.DeleteCustomer(id);
                return cstmrDto;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.InnerException);
                return null;
            }
        }

        public async Task<CustomerDto> PutCustomer(int id, CustomerDto customer)
        {
            try
            {
                CustomerDto customerDto = await _customerRepository.UpdateCustomer(id, customer);
                return customerDto;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.InnerException);
                return null;
            }
        }

    }

}

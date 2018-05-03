using Common.Dtoes;
using Common.Repos.Infra;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public async Task<IEnumerable<CustomerDto>> GetCustomers()
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    IEnumerable<Customer> customers = await db.Customers.ToListAsync();
                    return customers.Select(cstmr => cstmr.ToDto()).ToList();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public async Task<CustomerDto> GetCustomer(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    Customer customer = await db.Customers.FindAsync(id);
                    return customer.ToDto();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }

            }
        }

        public async Task<CustomerDto> CreateCustomer(CustomerDto customerDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (customerDto == null) return null;
                    else
                    {
                        db.Customers.Add(customerDto.ToModel());
                        await db.SaveChangesAsync();
                        return customerDto;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }

            }
        }

        public async Task<CustomerDto> UpdateCustomer(int id, CustomerDto customerDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (id != customerDto.CustomerId) return null;
                    else
                    {
                        Customer cs = db.Customers.FirstOrDefault(c => c.CustomerId == id);
                        if (cs == null) return null;
                        else
                        {
                            cs = customerDto.ToModel();
                            db.Entry(cs).State = System.Data.Entity.EntityState.Modified;
                            await db.SaveChangesAsync();
                            return cs.ToDto();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }

            }
        }

        public async Task<CustomerDto> DeleteCustomer(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    Customer customer = await db.Customers.FindAsync(id);
                    if (customer == null) return null;
                    else
                    {
                        db.Customers.Remove(customer);
                        await db.SaveChangesAsync();
                        return customer.ToDto();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }

            }
        }

        //public async Task<CustomerDto> UpdateCustomerType(int customerId, int typeId)
        //{
        //    using (CellularCompanyContext db = new CellularCompanyContext())
        //    {
        //        try
        //        {
        //            Customer customer = db.Customers.FirstOrDefault(c => c.CustomerId == customerId);
        //            if (customer == null) return null;
        //            else
        //            {
        //                customer.CustomerId = typeId;
        //                db.Entry(customer).Property(nameof(customer)).IsModified = true;
        //                await db.SaveChangesAsync();
        //                return customer.ToDto();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Debug.WriteLine(ex.Message);
        //            return null;
        //        }
        //    }

        //}

        //public async Task<IEnumerable<int>> GetCustomerIds()  ////????????????
        //{
        //    IEnumerable<CustomerDto> customers = await GetCustomers();
        //    if (customers == null) return null;
        //    else
        //    {
        //        return customers.Select(c => c.CustomerId).ToList();
        //    }
        //}

        //public IEnumerable<LineDto> GetCustomerLines(int customerId)
        //{
        //    using (CellularCompanyContext db = new CellularCompanyContext())
        //    {
        //        try
        //        {
        //            Customer customer = db.Customers.FirstOrDefault(c => c.CustomerId == customerId);
        //            if (customer == null) return null;
        //            else
        //            {
        //                return customer.Lines.Select(line => line.ToDto()).ToList();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Debug.WriteLine(ex.Message);
        //            return null;
        //        }
        //    }
        //}

    }
}

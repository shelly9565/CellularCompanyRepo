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
    public class CustomerTypeRepository : ICustomerTypeRepository
    {
        public async Task<IEnumerable<CustomerTypeDto>> GetCustomerTypes()
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    IEnumerable<CustomerType> customerTypes = await db.CustomerTypes.ToListAsync();
                    return customerTypes.Select(cstmr => cstmr.ToDto()).ToList();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
              
            }
        }

        public async Task<CustomerTypeDto> GetCustomerType(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    CustomerType customerType = await db.CustomerTypes.FindAsync(id);
                    return customerType.ToDto();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
              
            }

        }

        public async Task<CustomerTypeDto> CreateCustomerType(CustomerTypeDto customerTypeDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (customerTypeDto == null) return null;
                    else
                    {
                        db.CustomerTypes.Add(customerTypeDto.ToModel());
                        await db.SaveChangesAsync();
                        return customerTypeDto;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
               
            }
        }

        public async Task<CustomerTypeDto> UpdateCustomerType(int id, CustomerTypeDto customerTypeDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (id != customerTypeDto.CustomerTypeId) return null;
                    else
                    {
                        CustomerType ct = db.CustomerTypes.FirstOrDefault(c => c.CustomerTypeId == id);
                        if (ct == null) return null;
                        else
                        {
                            ct = customerTypeDto.ToModel();
                            db.Entry(ct).State = System.Data.Entity.EntityState.Modified;
                            await db.SaveChangesAsync();
                            return ct.ToDto();
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

        public async Task<CustomerTypeDto> DeleteCustomerType(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    CustomerType customerType = await db.CustomerTypes.FindAsync(id);
                    if (customerType == null) return null;
                    else
                    {
                        db.CustomerTypes.Remove(customerType);
                        await db.SaveChangesAsync();
                        return customerType.ToDto();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
              
            }
        }




    }
}

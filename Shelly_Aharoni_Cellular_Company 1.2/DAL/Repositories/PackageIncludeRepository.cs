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
    public class PackageIncludeRepository : IPackageIncludeRepository
    {
        public async Task<IEnumerable<PackageIncludeDto>> GetPackageIncludes()
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    IEnumerable<PackageInclude> packageIncludes = await db.PackageIncludes.ToListAsync();
                    return packageIncludes.Select(cstmr => cstmr.ToDto()).ToList();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
        
            }

        }

        public async Task<PackageIncludeDto> GetPackageInclude(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    PackageInclude packageInclude = await db.PackageIncludes.FindAsync(id);
                    return packageInclude.ToDto();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            
            }
        }

        public async Task<PackageIncludeDto> CreatePackageInclude(PackageIncludeDto packageIncludeDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (packageIncludeDto == null) return null;
                    else
                    {
                        db.PackageIncludes.Add(packageIncludeDto.ToModel());
                        await db.SaveChangesAsync();
                        return packageIncludeDto;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
               
            }
        }

        public async Task<PackageIncludeDto> UpdatePackageInclude(int id, PackageIncludeDto packageIncludeDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (id != packageIncludeDto.PackageIncludeId) return null;
                    else
                    {
                        PackageInclude pi = db.PackageIncludes.FirstOrDefault(p => p.PackageIncludeId == id);
                        if (pi == null) return null;
                        else
                        {
                            pi = packageIncludeDto.ToModel();
                            db.Entry(pi).State = System.Data.Entity.EntityState.Modified;
                            await db.SaveChangesAsync();
                            return pi.ToDto();
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

        public async Task<PackageIncludeDto> DeletePackageInclude(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    PackageInclude package = await db.PackageIncludes.FindAsync(id);
                    if (package == null) return null;
                    else
                    {
                        db.PackageIncludes.Remove(package);
                        await db.SaveChangesAsync();
                        return package.ToDto();
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

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
    public class PackageRepository : IPackageRepository
    {
        public async Task<IEnumerable<PackageDto>> GetEntities()
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    IEnumerable<Package> packages = await db.Packages.ToListAsync();
                    return packages.Select(p => p.ToDto()).ToList();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
               
            }
        }

        public async Task<PackageDto> GetPackage(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    Package package = await db.Packages.FindAsync(id);
                    return package.ToDto();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
           
            }
        }

        public async Task<PackageDto> CreatePackage(PackageDto packageDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (packageDto == null) return null;
                    else
                    {
                        db.Packages.Add(packageDto.ToModel());
                        await db.SaveChangesAsync();
                        return packageDto;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
             
            }
        }

        public async Task<PackageDto> UpdatePackage(int id, PackageDto packageDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (id != packageDto.PackageId) return null;
                    else
                    {
                        Package p = db.Packages.FirstOrDefault(c => c.PackageId == id);
                        if (p == null) return null;
                        else
                        {
                            p = packageDto.ToModel();
                            db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                            await db.SaveChangesAsync();
                            return p.ToDto();
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

        public async Task<PackageDto> DeletePackage(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    Package package = await db.Packages.FindAsync(id);
                    if (package == null) return null;
                    else
                    {
                        db.Packages.Remove(package);
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

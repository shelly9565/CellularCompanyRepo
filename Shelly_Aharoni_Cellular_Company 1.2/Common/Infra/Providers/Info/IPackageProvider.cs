using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infra.Providers.Info
{
    public interface IPackageProvider
    {
        Task<IEnumerable<PackageDto>> GetAllPackages();
        Task<PackageDto> GetPackage (int id);
        Task<PackageDto> AddPackage(PackageDto packageDto);
        Task<PackageDto> UpdatePackage(int id, PackageDto packageDto);
        Task<PackageDto> RemovePackage(int id);

    }
}

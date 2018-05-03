using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repos.Infra
{
    public interface IPackageRepository
    {
        Task<IEnumerable<PackageDto>> GetPackages();
        Task<PackageDto> GetPackage(int id);
        Task<PackageDto> CreatePackage(PackageDto packageDto);
        Task<PackageDto> UpdatePackage(int id, PackageDto packageDto);
        Task<PackageDto> DeletePackage(int id);
    }
}

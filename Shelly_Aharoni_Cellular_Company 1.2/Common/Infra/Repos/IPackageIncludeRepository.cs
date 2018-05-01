using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repos.Infra
{
    public interface IPackageIncludeRepository
    {
        Task<IEnumerable<PackageIncludeDto>> GetPackageIncludes();
        Task<PackageIncludeDto> GetPackageInclude(int id);
        Task<PackageIncludeDto> CreatePackageInclude(PackageIncludeDto packageIncludeDto);
        Task<PackageIncludeDto> UpdatePackageInclude(int id, PackageIncludeDto packageIncludeDto);
        Task<PackageIncludeDto> DeletePackageInclude(int id);
    }
}

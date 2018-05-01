using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infra.Providers.Repo
{
    public interface IPackageIncludeProvider
    {
        Task<IEnumerable<PackageIncludeDto>> GetAllPackageIncludes();
        Task<PackageIncludeDto> GetPackageInclude(int id);
        Task<PackageIncludeDto> AddPackageInclude(PackageIncludeDto packageIncludeDto);
        Task<PackageIncludeDto> UpdatePackageInclude(int id, PackageIncludeDto packageIncludeDto);
        Task<PackageIncludeDto> RemovePackageInclude(int id);
    }
}

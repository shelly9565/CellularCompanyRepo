using Autofac;
using Common.Dtoes;
using Common.Infra.Providers.Repo;
using Common.Repos.Infra;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Providers.Repo
{
    public class PackageIncludeProvider : IPackageIncludeProvider
    {
        private static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<PackageIncludeRepository>()
                    .As<IPackageIncludeRepository>()
                    .SingleInstance();
            return builder.Build();
        }

        public async Task<PackageIncludeDto> AddPackageInclude(PackageIncludeDto packageIncludeDto)
        {
            return await GetContainer().Resolve<IPackageIncludeRepository>().CreatePackageInclude(packageIncludeDto);
        }

        public async Task<IEnumerable<PackageIncludeDto>> GetAllPackageIncludes()
        {
            return await GetContainer().Resolve<IPackageIncludeRepository>().GetPackageIncludes();
        }

        public async Task<PackageIncludeDto> GetPackageInclude(int id)
        {
            return await GetContainer().Resolve<IPackageIncludeRepository>().GetPackageInclude(id);
        }

        public async Task<PackageIncludeDto> RemovePackageInclude(int id)
        {
            return await GetContainer().Resolve<IPackageIncludeRepository>().DeletePackageInclude(id);
        }

        public async Task<PackageIncludeDto> UpdatePackageInclude(int id, PackageIncludeDto packageIncludeDto)
        {
            return await GetContainer().Resolve<IPackageIncludeRepository>().UpdatePackageInclude( id, packageIncludeDto);
        }
    }
}

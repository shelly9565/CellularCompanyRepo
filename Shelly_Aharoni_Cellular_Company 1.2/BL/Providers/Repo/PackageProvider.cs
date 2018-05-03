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
    public class PackageProvider : IPackageProvider
    {
        private static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<PackageRepository>()
                    .As<IPackageRepository>()
                    .SingleInstance();
            return builder.Build();
        }

        public async Task<PackageDto> AddPackage(PackageDto packageDto)
        {
            return await GetContainer().Resolve<IPackageRepository>().CreatePackage(packageDto);
        }

        public async Task<IEnumerable<PackageDto>> GetAllPackages()
        {
            return await GetContainer().Resolve<IPackageRepository>().GetPackages();
        }

        public async Task<PackageDto> GetPackage(int id)
        {
            return await GetContainer().Resolve<IPackageRepository>().GetPackage(id);
        }

        public async Task<PackageDto> RemovePackage(int id)
        {
            return await GetContainer().Resolve<IPackageRepository>().DeletePackage(id);
        }

        public async Task<PackageDto> UpdatePackage(int id, PackageDto packageDto)
        {
            return await GetContainer().Resolve<IPackageRepository>().UpdatePackage( id, packageDto);
        }
    }
}

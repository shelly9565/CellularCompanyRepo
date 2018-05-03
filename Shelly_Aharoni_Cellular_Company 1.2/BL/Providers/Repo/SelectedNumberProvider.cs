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
    public class SelectedNumberProvider : ISelectedNumberProvider
    {
        private static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SelectedNumberRepository>()
                    .As<ISelectedNumberRepository>()
                    .SingleInstance();
            return builder.Build();
        }

        public async Task<SelectedNumberDto> AddSelectedNumber(SelectedNumberDto selectedNumberDto)
        {
            return await GetContainer().Resolve<ISelectedNumberRepository>().CreateSelectedNumber(selectedNumberDto);
        }

        public async Task<IEnumerable<SelectedNumberDto>> GetAllSelectedNumbers()
        {
            return await GetContainer().Resolve<ISelectedNumberRepository>().GetSelectedNumbers();
        }

        public async Task<SelectedNumberDto> GetSelectedNumber(int id)
        {
            return await GetContainer().Resolve<ISelectedNumberRepository>().GetSelectedNumber(id);
        }

        public async Task<SelectedNumberDto> RemoveSelectedNumber(int id)
        {
            return await GetContainer().Resolve<ISelectedNumberRepository>().DeleteSelectedNumber(id);
        }

        public async Task<SelectedNumberDto> UpdateSelectedNumber(int id, SelectedNumberDto selectedNumberDto)
        {
            return await GetContainer().Resolve<ISelectedNumberRepository>().UpdateSelectedNumber(id, selectedNumberDto);
        }
    }
}

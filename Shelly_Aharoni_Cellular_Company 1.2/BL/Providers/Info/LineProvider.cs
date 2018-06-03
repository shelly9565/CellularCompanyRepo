using Autofac;
using Common.Dtoes;
using Common.Infra.Providers.Info;
using Common.Repos.Infra;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Providers.Info
{
    public class LineProvider : ILineProvider
    {
        private static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<LineRepository>()
                    .As<ILineRepository>()
                    .SingleInstance();
            return builder.Build();
        }

        public async Task<LineDto> AddLine(LineDto lineDto)
        {
            return await GetContainer().Resolve<ILineRepository>().CreateLine(lineDto);
        }

        public async Task<IEnumerable<LineDto>> GetAllLines()
        {
            return await GetContainer().Resolve<ILineRepository>().GetLines();
        }

        public async Task<LineDto> GetLine(int id)
        {
            return await GetContainer().Resolve<ILineRepository>().GetLine(id);
        }

        public async Task<LineDto> RemoveLine(int id)
        {
            return await GetContainer().Resolve<ILineRepository>().DeleteLine(id);
        }

        public async Task<LineDto> UpdateLine(int id, LineDto lineDto)
        {
            return await GetContainer().Resolve<ILineRepository>().UpdateLine(id, lineDto);
        }

        public async Task<IEnumerable<LineDto>> GetDestinationLines(int lineId)
        {
            IEnumerable<LineDto> lines = GetContainer().Resolve<ILineRepository>().GetLines().Result;
            return lines.Where(l => l.LineId != lineId);
        }
    }
}


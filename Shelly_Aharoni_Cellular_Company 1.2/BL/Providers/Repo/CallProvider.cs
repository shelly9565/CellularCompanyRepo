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
    public class CallProvider : ICallProvider
    {
        private static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CallRepository>()
                    .As<ICallRepository>()
                    .SingleInstance();
            return builder.Build();
        }

        public async Task<CallDto> AddCall(CallDto dto)
        {
            return await GetContainer().Resolve<ICallRepository>().CreateCall(dto);
        }

        public async Task<CallDto> RemoveCall(int callId)
        {
            return await GetContainer().Resolve<ICallRepository>().DeleteCall(callId);
        }

        public async Task<CallDto> UpdateCall(int callId, CallDto callDto)
        {
            return await GetContainer().Resolve<ICallRepository>().UpdateCall(callId, callDto);
        }

        public async Task<CallDto> GetCall(int callId)
        {
            return await GetContainer().Resolve<ICallRepository>().GetCall(callId);
        }

        public async Task<IEnumerable<CallDto>> GetAllCalls()
        {
            return await GetContainer().Resolve<ICallRepository>().GetCalls();
        }
    }
}

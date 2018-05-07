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
   public  class SmsProvider : ISmsProvider
    {
        private static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SMSRepository>()
                    .As<ISMSRepository>()
                    .SingleInstance();
            return builder.Build();
        }

        public async Task<SMSDto> AddSMS(SMSDto smsDto)
        {
            return await GetContainer().Resolve<ISMSRepository>().CreateSMS(smsDto);
        }

        public async Task<IEnumerable<SMSDto>> GetAllSMSes()
        {
            return await GetContainer().Resolve<ISMSRepository>().GetSMSes();
        }

        public async Task<SMSDto> GetSMS(int id)
        {
            return await GetContainer().Resolve<ISMSRepository>().GetSMS(id);
        }

        public async Task<SMSDto> RemoveSMS(int id)
        {
            return await GetContainer().Resolve<ISMSRepository>().DeleteSMS(id);
        }

        public async Task<SMSDto> UpdateSMS(int id, SMSDto smsDto)
        {
            return await GetContainer().Resolve<ISMSRepository>().UpdateSMS(id, smsDto);
        }
    }
}

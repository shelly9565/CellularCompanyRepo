using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infra.Providers.Info
{
    public interface ISmsProvider
    {
        Task<IEnumerable<SMSDto>> GetAllSMSes();
        Task<SMSDto> GetSMS(int id);
        Task<SMSDto> AddSMS(SMSDto smsDto);
        Task<SMSDto> UpdateSMS(int id, SMSDto smsDto);
        Task<SMSDto> RemoveSMS(int id);
    }
}

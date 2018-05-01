using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repos.Infra
{
    public interface ISMSRepository
    {
        Task<IEnumerable<SMSDto>> GetSMSes();
        Task<SMSDto> GetSMS(int id);
        Task<SMSDto> CreateSMS(SMSDto smsDto);
        Task<SMSDto> UpdateSMS(int id, SMSDto smsDto);
        Task<SMSDto> DeleteSMS(int id);
    }

}

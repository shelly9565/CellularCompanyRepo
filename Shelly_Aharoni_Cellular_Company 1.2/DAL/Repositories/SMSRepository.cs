using Common.Dtoes;
using Common.Repos.Infra;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SMSRepository : ISMSRepository
    {
        public async Task<IEnumerable<SMSDto>> GetSMSes()
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                IEnumerable<SMS> smses = await db.SMSs.ToListAsync();
                return smses.Select(s => s.ToDto()).ToList();
            }
        }

        public async Task<SMSDto> GetSMS(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                SMS sms = await db.SMSs.FindAsync(id);
                return sms.ToDto();
            }
        }

        public async Task<SMSDto> CreateSMS(SMSDto smsDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                if (smsDto == null) return null;
                else
                {
                    db.SMSs.Add(smsDto.ToModel());
                    await db.SaveChangesAsync();
                    return smsDto;
                }
            }
        }

        public async Task<SMSDto> UpdateSMS(int id, SMSDto smsDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                if (id != smsDto.SMSId) return null;
                else
                {
                    var sms = db.SMSs.FirstOrDefault(s => s.SMSId == id);
                    if (sms == null) return null;
                    else
                    {
                        SMS sMS = smsDto.ToModel();
                        db.Entry(sMS).State = System.Data.Entity.EntityState.Modified;
                        await db.SaveChangesAsync();
                        return sms.ToDto();
                    }
                }
            }
        }

        public async Task<SMSDto> DeleteSMS(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                SMS sMS  = await db.SMSs.FindAsync(id);
                if (sMS == null) return null;
                else
                {
                    db.SMSs.Remove(sMS);
                    await db.SaveChangesAsync();
                    return sMS.ToDto();
                }
            }
        }

    }

}

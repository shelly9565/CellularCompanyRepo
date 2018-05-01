using Common.Dtoes;
using Common.Repos.Infra;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CallRepository : ICallRepository
    {
        public async Task<IEnumerable<CallDto>> GetCalls()
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    IEnumerable<Call> calls = await db.Calls.ToListAsync();
                    return calls.Select(c => c.ToDto()).ToList();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public async Task<CallDto> GetCall(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    Call call = await db.Calls.FindAsync(id);
                    return call.ToDto();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }

            }
        }

        public async Task<CallDto> CreateCall(CallDto callDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (callDto == null) return null;
                    else
                    {
                        db.Calls.Add(callDto.ToModel());
                        await db.SaveChangesAsync();
                        return callDto;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }

            }
        }

        public async Task<CallDto> UpdateCall(int id, CallDto callDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (id != callDto.CallId) return null;
                    else
                    {
                        Call call = db.Calls.FirstOrDefault(c => c.CallId == id);
                        if (call == null) return null;
                        else
                        {
                            call = callDto.ToModel();
                            db.Entry(call).State = System.Data.Entity.EntityState.Modified;
                            await db.SaveChangesAsync();
                            return call.ToDto();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }

            }
        }

        public async Task<CallDto> DeleteCall(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    Call  call = await db.Calls.FindAsync(id);
                    if (call == null) return null;
                    else
                    {
                        db.Calls.Remove(call);
                        await db.SaveChangesAsync();
                        return call.ToDto();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }

            }
        }
    }
}

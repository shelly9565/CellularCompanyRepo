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
    public class SelectedNumberRepository : ISelectedNumberRepository
    {
        public async Task<IEnumerable<SelectedNumberDto>> GetSelectedNumbers()
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                IEnumerable<SelectedNumber> selectedNumbers = await db.SelectedNumbers.ToListAsync();
                return selectedNumbers.Select(cstmr => cstmr.ToDto()).ToList();
            }
        }

        public async Task<SelectedNumberDto> GetSelectedNumber(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                SelectedNumber selectedNumber = await db.SelectedNumbers.FindAsync(id);
                return selectedNumber.ToDto();
            }
        }

        public async Task<SelectedNumberDto> CreateSelectedNumber(SelectedNumberDto selectedNumberDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                if (selectedNumberDto == null) return null;
                else
                {
                    db.SelectedNumbers.Add(selectedNumberDto.ToModel());
                    await db.SaveChangesAsync();
                    return selectedNumberDto;
                }
            }
        }

        public async Task<SelectedNumberDto> UpdateSelectedNumber(int id, SelectedNumberDto selectedNumberDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                if (id != selectedNumberDto.SelectedNumberId) return null;
                else
                {
                    var sn = db.SelectedNumbers.FirstOrDefault(s => s.SelectedNumberId == id);
                    if (sn == null) return null;
                    else
                    {
                        SelectedNumber selectedNumber = selectedNumberDto.ToModel();
                        db.Entry(selectedNumber).State = System.Data.Entity.EntityState.Modified;
                        await db.SaveChangesAsync();
                        return sn.ToDto();
                    }
                }
            }
        }

        public async Task<SelectedNumberDto> DeleteSelectedNumber(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                SelectedNumber selectedNumber = await db.SelectedNumbers.FindAsync(id);
                if (selectedNumber == null) return null;
                else
                {
                    db.SelectedNumbers.Remove(selectedNumber);
                    await db.SaveChangesAsync();
                    return selectedNumber.ToDto();
                }
            }
        }



    }
}

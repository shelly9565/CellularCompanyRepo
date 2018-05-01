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
    public class LineRepository : ILineRepository
    {
        public async Task<IEnumerable<LineDto>> GetLines()
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    IEnumerable<Line> lines = await db.Lines.ToListAsync();
                    return lines.Select(line => line.ToDto()).ToList();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
           
            }
        }

        public async Task<LineDto> GetLine(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    Line line = await db.Lines.FindAsync(id);
                    return line.ToDto();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
               
            }
        }

        public async Task<LineDto> CreateLine(LineDto lineDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (lineDto == null) return null;
                    else
                    {
                        db.Lines.Add(lineDto.ToModel());
                        await db.SaveChangesAsync();
                        return lineDto;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
              
            }
        }

        public async Task<LineDto> UpdateLine(int id, LineDto lineDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (id != lineDto.CustomerId) return null;
                    else
                    {
                        Line ln = db.Lines.FirstOrDefault(l => l.LineId == id);
                        if (ln == null) return null;
                        else
                        {
                            ln = lineDto.ToModel();
                            db.Entry(ln).State = System.Data.Entity.EntityState.Modified;
                            await db.SaveChangesAsync();
                            return ln.ToDto();
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

        public async Task<LineDto> DeleteLine(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    Line line = await db.Lines.FindAsync(id);
                    if (line == null) return null;
                    else
                    {
                        db.Lines.Remove(line);
                        await db.SaveChangesAsync();
                        return line.ToDto();
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

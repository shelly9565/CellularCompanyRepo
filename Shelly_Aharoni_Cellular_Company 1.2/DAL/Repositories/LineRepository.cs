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

        public async Task<LineDto> CreateLine(LineDto lineDto, SelectedNumberDto selectedNumberDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    if (lineDto == null) return null;
                    else
                    {
                        lineDto.SelectedNumbers = selectedNumberDto;
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
                    if (lineDto != null && id != 0 && CheckIfLineNumberAlreadyExist(lineDto.Number))
                    {
                        lineDto.LineId = id;
                        Line entity = lineDto.ToModel();
                        db.Lines.Attach(entity);
                        foreach (var propName in db.Entry(entity).CurrentValues.PropertyNames)
                        {
                            if (propName != nameof(entity.LineId))
                            {
                                db.Entry(entity).Property(propName).IsModified = true;
                            }
                        }
                        await db.SaveChangesAsync();
                        return entity.ToDto();
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }

            }
        }

        public bool CheckIfLineNumberAlreadyExist(string number)
        {
            using (var db = new CellularCompanyContext())
            {
                return db.Lines.All(l => l.Number == number);
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

        public LineDto GetLineByNumber(string number)
        {
            using (var db = new CellularCompanyContext())
            {
                try
                {
                    return  db.Lines.Where(l => l.Number == number).FirstOrDefault().ToDto();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public IEnumerable<string> GetLineSelectedNumbers(int lineId)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                try
                {
                    List<string> list = new List<string>();
                    SelectedNumbers entity = db.SelectedNumbers.Where(s => s.Line.LineId == lineId).FirstOrDefault();
                    foreach (var propName in db.Entry(entity).CurrentValues.PropertyNames)
                    {
                        if (propName.EndsWith("Number"))
                        {
                            if (db.Entry(entity).Property(propName).CurrentValue != null)
                                list.Add(db.Entry(entity).Property(propName).CurrentValue.ToString());
                        }
                    }

                    return list;
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

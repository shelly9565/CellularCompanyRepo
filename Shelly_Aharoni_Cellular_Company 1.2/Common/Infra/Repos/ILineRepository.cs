using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repos.Infra
{
    public interface ILineRepository
    {
        Task<IEnumerable<LineDto>> GetLines();
        Task<LineDto> GetLine(int id);
        Task<LineDto> CreateLine(LineDto lineDto, SelectedNumberDto selectedNumberDto);
        Task<LineDto> UpdateLine(int id, LineDto lineDto);
        Task<LineDto> DeleteLine(int id);
        bool CheckIfLineNumberAlreadyExist(string number);
        LineDto GetLineByNumber(string number);
        IEnumerable<string> GetLineSelectedNumbers(int lineId);
    }
}

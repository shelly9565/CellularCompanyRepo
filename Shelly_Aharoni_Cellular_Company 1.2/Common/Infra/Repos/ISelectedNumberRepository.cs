using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repos.Infra
{
    public interface ISelectedNumberRepository
    {
        Task<IEnumerable<SelectedNumberDto>> GetSelectedNumbers();
        Task<SelectedNumberDto> GetSelectedNumber(int id);
        Task<SelectedNumberDto> CreateSelectedNumber(SelectedNumberDto selectedNumberDto);
        Task<SelectedNumberDto> UpdateSelectedNumber(int id, SelectedNumberDto selectedNumberDto);
        Task<SelectedNumberDto> DeleteSelectedNumber(int id);
    }
}

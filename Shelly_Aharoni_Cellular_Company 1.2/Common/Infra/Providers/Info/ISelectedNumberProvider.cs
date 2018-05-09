using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infra.Providers.Info
{
    public interface ISelectedNumberProvider
    {
        Task<IEnumerable<SelectedNumberDto>> GetAllSelectedNumbers();
        Task<SelectedNumberDto> GetSelectedNumber(int id);
        Task<SelectedNumberDto> AddSelectedNumber(SelectedNumberDto selectedNumberDto);
        Task<SelectedNumberDto> UpdateSelectedNumber(int id, SelectedNumberDto selectedNumberDto);
        Task<SelectedNumberDto> RemoveSelectedNumber(int id);
    }
}

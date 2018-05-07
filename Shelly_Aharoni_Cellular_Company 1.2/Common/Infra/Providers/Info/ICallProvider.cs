using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infra.Providers.Info
{
    public interface ICallProvider
    {
        Task<IEnumerable<CallDto>> GetAllCalls();
        Task<CallDto> GetCall(int id);
        Task<CallDto> AddCall(CallDto callDto);
        Task<CallDto> UpdateCall(int id, CallDto callDto);
        Task<CallDto> RemoveCall(int id);
    }
}

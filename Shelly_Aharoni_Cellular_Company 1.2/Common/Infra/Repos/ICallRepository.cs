using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repos.Infra
{
    public interface ICallRepository
    {
        Task<IEnumerable<CallDto>> GetCalls();
        Task<CallDto> GetCall(int id);
        Task<CallDto> CreateCall(CallDto callDto);
        Task<CallDto> UpdateCall(int id, CallDto callDto);
        Task<CallDto> DeleteCall(int id);

    }
}

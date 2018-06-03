using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infra.Providers.BL
{
    public interface IInvoiceProvider
    {
        Task<CallDto> CreateCall(CallDto call);
        Task<SMSDto> CreateSMS(SMSDto sms);
    }
}

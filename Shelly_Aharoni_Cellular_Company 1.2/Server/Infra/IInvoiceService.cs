using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server.Infra
{
    [ServiceContract]
    public interface IInvoiceService
    {
        [OperationContract]
        Task<SMSDto> AddSMS(SMSDto sms);
        [OperationContract]
        Task<CallDto> AddCall(CallDto call);
    }
}

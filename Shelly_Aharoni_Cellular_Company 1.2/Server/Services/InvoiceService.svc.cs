using Common.Dtoes;
using Common.Infra.Providers.BL;
using Server.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceProvider _invoiceProvider;

        public InvoiceService(IInvoiceProvider inviceProvider)
        {
            _invoiceProvider = inviceProvider;
        }

        public async Task<CallDto> AddCall(CallDto call)
        {
            return await _invoiceProvider.CreateCall(call);
        }

        public async Task<SMSDto> AddSMS(SMSDto sms)
        {
            return await _invoiceProvider.CreateSMS(sms);
        }
    }
}

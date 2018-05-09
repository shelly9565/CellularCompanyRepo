using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infra.Providers.Info
{
    public interface IPaymentProvider
    {
        Task<IEnumerable<PaymentDto>> GetAllPayments();
        Task<PaymentDto> GetPayment(int id);
        Task<PaymentDto> AddPayment(PaymentDto paymentDto);
        Task<PaymentDto> UpdatePayment(int id, PaymentDto paymentDto);
        Task<PaymentDto> RemovePayment(int id);
    }
}

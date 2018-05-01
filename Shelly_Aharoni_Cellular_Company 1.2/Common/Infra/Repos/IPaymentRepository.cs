using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repos.Infra
{
    public interface IPaymentRepository
    {
        Task<IEnumerable<PaymentDto>> GetPayments();
        Task<PaymentDto> GetPayment(int id);
        Task<PaymentDto> CreatePayment(PaymentDto paymentDto);
        Task<PaymentDto> UpdatePayment(int id, PaymentDto paymentDto);
        Task<PaymentDto> DeletePayment(int id);
    }
}

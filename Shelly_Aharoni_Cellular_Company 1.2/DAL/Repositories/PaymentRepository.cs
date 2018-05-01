using Common.Dtoes;
using Common.Repos.Infra;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        public async Task<IEnumerable<PaymentDto>> GetPayments()
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                IEnumerable<Payment> payments = await db.Payments.ToListAsync();
                return payments.Select(py => py.ToDto()).ToList();
            }
        }

        public async Task<PaymentDto> GetPayment(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                Payment payment = await db.Payments.FindAsync(id);
                return payment.ToDto();
            }
        }

        public async Task<PaymentDto> CreatePayment(PaymentDto paymentDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                if (paymentDto == null) return null;
                else
                {
                    db.Payments.Add(paymentDto.ToModel());
                    await db.SaveChangesAsync();
                    return paymentDto;
                }
            }
        }

        public async Task<PaymentDto> UpdatePayment(int id, PaymentDto paymentDto)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                if (id != paymentDto.CustomerId) return null;
                else
                {
                    var py = db.Payments.FirstOrDefault(p => p.PaymentId == id);
                    if (py == null) return null;
                    else
                    {
                        Payment payment = paymentDto.ToModel();
                        db.Entry(payment).State = System.Data.Entity.EntityState.Modified;
                        await db.SaveChangesAsync();
                        return py.ToDto();
                    }
                }
            }
        }

        public async Task<PaymentDto> DeletePayment(int id)
        {
            using (CellularCompanyContext db = new CellularCompanyContext())
            {
                Payment payment = await db.Payments.FindAsync(id);
                if (payment == null) return null;
                else
                {
                    db.Payments.Remove(payment);
                    await db.SaveChangesAsync();
                    return payment.ToDto();
                }
            }
        }

    }
}

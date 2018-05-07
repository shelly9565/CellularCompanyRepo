using Autofac;
using Common.Dtoes;
using Common.Infra.Providers.Info;
using Common.Repos.Infra;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Providers.Info
{
    public class PaymentProvider : IPaymentProvider
    {
        private static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<PaymentRepository>()
                    .As<IPaymentRepository>()
                    .SingleInstance();
            return builder.Build();
        }

        public async Task<PaymentDto> AddPayment(PaymentDto paymentDto)
        {
            return await GetContainer().Resolve<IPaymentRepository>().CreatePayment(paymentDto);
        }

        public async Task<IEnumerable<PaymentDto>> GetAllPayments()
        {
            return await GetContainer().Resolve<IPaymentRepository>().GetPayments();
        }

        public async Task<PaymentDto> GetPayment(int id)
        {
            return await GetContainer().Resolve<IPaymentRepository>().GetPayment(id);
        }

        public async Task<PaymentDto> RemovePayment(int id)
        {
            return await GetContainer().Resolve<IPaymentRepository>().DeletePayment(id);
        }

        public async Task<PaymentDto> UpdatePayment(int id, PaymentDto paymentDto)
        {
            return await GetContainer().Resolve<IPaymentRepository>().UpdatePayment(id, paymentDto);
        }
    }
}

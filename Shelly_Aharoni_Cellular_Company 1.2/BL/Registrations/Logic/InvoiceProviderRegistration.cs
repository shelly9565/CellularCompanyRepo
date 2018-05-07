using Autofac;
using BL.Providers.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Registrations.Logic
{
    public class InvoiceProviderRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<InvoiceProvider>()
                .As<IInvoiceProvider>()
                .SingleInstance();
            base.Load(builder);
        }
    }
}

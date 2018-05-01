using Autofac;
using BL.Providers.Logic;
using Common.Providers.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Registrations.Logic.ProviderRegistration
{
    public class CRMRegisration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CRMProvider>()
                .As<ICRMProvider>()
                .SingleInstance();
            base.Load(builder);
        }
    }
}

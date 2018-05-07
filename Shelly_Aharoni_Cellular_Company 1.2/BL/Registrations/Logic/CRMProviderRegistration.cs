using Autofac;
using BL.Providers.Logic;
using Common.Providers.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Registrations.Logic
{
    public class CRMProviderRegistration : Module
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

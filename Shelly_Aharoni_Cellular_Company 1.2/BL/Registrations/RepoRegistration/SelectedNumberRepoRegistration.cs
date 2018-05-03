using Autofac;
using Common.Repos.Infra;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Registrations.Repo
{
    public class SelectedNumberRepoRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SelectedNumberRepository>()
                   .As<ISelectedNumberRepository>()
                   .SingleInstance();

            base.Load(builder);
        }
    }

}

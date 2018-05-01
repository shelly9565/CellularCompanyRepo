﻿using Autofac;
using Common.Repos.Infra;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Registrations.Repo
{
    public class PackageIncludeRepoRegistration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PackageIncludeRepository>()
                   .As<IPackageIncludeRepository>()
                   .SingleInstance();

            base.Load(builder);
        }
    }

}

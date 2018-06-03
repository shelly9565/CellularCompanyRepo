namespace DAL.Migrations
{
    using DAL.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.CellularCompanyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

  
        protected override void Seed(DAL.CellularCompanyContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.CustomerTypes.AddOrUpdate(t => t.TypeName, new CustomerType() { TypeName = "Private", MinutePrice = 1.5, SMSPrice = 1 },
                                                               new CustomerType() { TypeName = "Business", MinutePrice = 1, SMSPrice = 0.5 },
                                                               new CustomerType() { TypeName = "VIP", MinutePrice = 0.5, SMSPrice = 0.25 });

            context.Packages.AddOrUpdate(p => p.PackageName, new Package() { PackageName = "All Includes", PackageTotalPrice = 40 },
                                                             new Package() { PackageName = "Unlimited", PackageTotalPrice = 30 },
                                                             new Package() { PackageName = "Family Extra", PackageTotalPrice = 45 });

            context.Packages.AddOrUpdate(p => p.PackageName, new Package() { PackageId = 1, PackageName = "All Includes", PackageTotalPrice = 100,
                                                                             PackageIncludes = new HashSet<PackageInclude>()
                                                                             {
                                                                                new PackageInclude()
                                                                                 {
                                                                                     InsideFamilyCalls=true,
                                                                                     DiscountPrecentage=60,
                                                                                     IncludeName="cheap family calls",
                                                                                     MaxMinute=120
                                                                                 },
                                                                                 new PackageInclude()
                                                                                 {
                                                                                     IncludeName="cheap most called number calls",
                                                                                     DiscountPrecentage=40,
                                                                                     MostCalledNumber=true,
                                                                                     MaxMinute=60
                                                                                 }
                                                                             }, },
                                                             new Package() {  PackageId = 2, PackageName = "Family Extra", PackageTotalPrice = 40,
                                                                              PackageIncludes = new HashSet<PackageInclude>()
                                                                              {
                                                                                  new PackageInclude()
                                                                                  {
                                                                                      InsideFamilyCalls=true,
                                                                                      DiscountPrecentage=80,
                                                                                      IncludeName="cheapier family talks",
                                                                                      MaxMinute=180,
                                                                              
                                                                                  }
                                                                              }
                                                             },
                                                             new Package() { PackageId = 3, PackageName = "Unlimited", PackageTotalPrice = 120,
                                                                             PackageIncludes = new HashSet<PackageInclude>()
                                                                                 {
                                                                                     new PackageInclude()
                                                                                     {
                                                                                         IncludeName="unlimited talks",
                                                                                         MaxMinute=int.MaxValue,
                                                                                         FixedPrice=80
                                                                                     }
                                                                             }
                                                             });
        }


    }
}

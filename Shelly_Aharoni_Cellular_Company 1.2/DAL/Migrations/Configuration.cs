namespace DAL.Migrations
{
    using System;
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
            context.CustomerTypes.AddOrUpdate(t => t.TypeName, new Models.CustomerType() { TypeName = "Private", MinutePrice = 1.5, SMSPrice = 1 },
                                                               new Models.CustomerType() { TypeName = "Business", MinutePrice = 1, SMSPrice = 0.5 },
                                                               new Models.CustomerType() { TypeName = "VIP", MinutePrice = 0.5, SMSPrice = 0.25 } );

            context.Packages.AddOrUpdate(p => p.PackageName, new Models.Package() { PackageName = "All Includes", PackageTotalPrice = 40 },
                                                             new Models.Package() { PackageName = "Unlimited", PackageTotalPrice = 30 },
                                                             new Models.Package() { PackageName = "Family Extra", PackageTotalPrice = 45 } );

        }
    }
}

using Common.Dtoes;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CellularCompanyContext : DbContext
    {
        public CellularCompanyContext() : base("name=CellularCompanyContext")
        {
        }

        public DbSet<Call> Calls { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Line> Lines { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PackageInclude> PackageIncludes { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<SelectedNumber> SelectedNumbers { get; set; }
        public DbSet<SMS> SMSs { get; set; }

    }
}

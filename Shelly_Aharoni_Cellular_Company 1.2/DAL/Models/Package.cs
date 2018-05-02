using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Package
    {
        public Package()
        {
            Lines = new HashSet<Line>();
            PackageIncludes = new HashSet<PackageInclude>();
        }

        [Key]
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public double PackageTotalPrice { get; set; }

        public virtual ICollection<Line> Lines { get; set; }
        public virtual ICollection<PackageInclude> PackageIncludes { get; set; }

    }
}

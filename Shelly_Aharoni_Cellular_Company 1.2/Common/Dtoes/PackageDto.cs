using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtoes
{
    public class PackageDto
    {
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public double PackageTotalPrice { get; set; }

        public virtual ICollection<LineDto> Lines { get; set; }
        public virtual ICollection<PackageIncludeDto> PackageIncludes { get; set; }

    }
}

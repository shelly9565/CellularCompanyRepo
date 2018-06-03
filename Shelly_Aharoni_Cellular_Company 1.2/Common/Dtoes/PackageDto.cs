using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtoes
{
    [DataContract]
    public class PackageDto
    {
        [DataMember]
        public int PackageId { get; set; }
        [DataMember]
        public string PackageName { get; set; }
        [DataMember]
        public double PackageTotalPrice { get; set; }

        public virtual IEnumerable<LineDto> Lines { get; set; }
        public virtual ICollection<PackageIncludeDto> PackageIncludes { get; set; }

    }
}

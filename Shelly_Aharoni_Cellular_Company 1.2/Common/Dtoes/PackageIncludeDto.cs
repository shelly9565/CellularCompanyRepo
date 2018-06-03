using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtoes
{
    [DataContract]
    public class PackageIncludeDto
    {
        [DataMember]
        public int PackageIncludeId { get; set; }
        [DataMember]
        public string IncludeName { get; set; }
        [DataMember]
        public int MaxMinute { get; set; }
        [DataMember]
        public double FixedPrice { get; set; }
        [DataMember]
        public double DiscountPrecentage { get; set; }
        [DataMember]
        public bool MostCalledNumber { get; set; }
        [DataMember]
        public bool InsideFamilyCalls { get; set; }

        [DataMember]
        public int PackageId { get; set; }
        [DataMember]
        public PackageDto Package { get; set; }


    }
}

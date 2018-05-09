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
    public class CustomerTypeDto
    {
        [DataMember]
        public int CustomerTypeId { get; set; }
        [DataMember]
        public string TypeName { get; set; }
        [DataMember]
        public double MinutePrice { get; set; }
        [DataMember]
        public double SMSPrice { get; set; }

        public virtual IEnumerable<CustomerDto> Customers { get; set; }

    }
}

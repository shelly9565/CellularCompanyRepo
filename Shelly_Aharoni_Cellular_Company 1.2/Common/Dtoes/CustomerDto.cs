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
    public class CustomerDto
    {
        [DataMember]
        public int CustomerId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string ContactNumber { get; set; }
        [DataMember]
        public int CallsToCenter { get; set; }
        [DataMember]
        public int? CustomerTypeId { get; set; }
        [DataMember]
        public CustomerTypeDto CustomerType { get; set; }

        [DataMember]
        public virtual ICollection<PaymentDto> Payments { get; set; }
        [DataMember]
        public virtual ICollection<LineDto> Lines { get; set; }

        public override string ToString()
        {
            return $"FirstName:{FirstName}, LastName:{LastName}";
        }
    }
}

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
    public class PaymentDto
    {
        [DataMember]
        public int PaymentId { get; set; }
        [DataMember]
        public DateTime PayDate { get; set; }
        [DataMember]
        public double TotalPayment { get; set; }
        [DataMember]
        public int CustomerId { get; set; }
        [DataMember]
        public CustomerDto Customer { get; set; }
    }
}

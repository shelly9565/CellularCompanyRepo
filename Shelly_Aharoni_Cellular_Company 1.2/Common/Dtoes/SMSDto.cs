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
    public class SMSDto
    {
        [DataMember]
        public int SMSId { get; set; }
        [DataMember]
        public double ExternalPrice { get; set; }
        [DataMember]
        public string DestinationNumber { get; set; }
        [DataMember]
        public DateTime SmsSendTime { get; set; }
        [DataMember]
        public int LineId { get; set; }
        [DataMember]
        public LineDto Line { get; set; }
    }
}

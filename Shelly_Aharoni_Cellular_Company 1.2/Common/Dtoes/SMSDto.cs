using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtoes
{
    public class SMSDto
    {
        public int SMSId { get; set; }
        public double ExternalPrice { get; set; }
        public string DestinationNumber { get; set; }
        public DateTime SmsSendTime { get; set; }
        public int LineId { get; set; }
        public LineDto Line { get; set; }
    }
}

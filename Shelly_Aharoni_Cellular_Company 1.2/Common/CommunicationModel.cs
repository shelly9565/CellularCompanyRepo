using Common.Dtoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CommunicationModel
    {
        public double ExternalPrice { get; set; }
        public string DestinationNumber { get; set; }
        public DateTime Time { get; set; }
        public int LineId { get; set; }
        public LineDto Line { get; set; }
    }
}

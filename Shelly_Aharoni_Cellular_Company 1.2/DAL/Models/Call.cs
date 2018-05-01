using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Call
    {
        [Key]
        public int CallId { get; set; }
        public double Duration { get; set; }
        public double ExternalPrice { get; set; }
        public string DestinationNumber { get; set; }

        [ForeignKey("Line")]
        public int LineId { get; set; }
        public Line Line { get; set; }
    }
}

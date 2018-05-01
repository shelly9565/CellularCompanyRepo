using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Line
    {
        [Key]
        public int LineId { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }

        [ForeignKey("Package")]
        public int PackageId { get; set; }
        public Package Package { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public virtual ICollection<SMS> SMSes { get; set; }
        public virtual ICollection<Call> Calls { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Status
{
    Available,
    Used,
    Stolen,
    Blocked
}

namespace Common.Dtoes
{
    public class LineDto
    {
        public int LineId { get; set; }
        public string Number { get; set; }
        public Status Status { get; set; }
        public int PackageId { get; set; }
        public PackageDto Package { get; set; }
        public int CustomerId { get; set; }
        public CustomerDto Customer { get; set; }

        public virtual ICollection<SMSDto> SMSes { get; set; }
        public virtual ICollection<CallDto> Calls { get; set; }

    }
}

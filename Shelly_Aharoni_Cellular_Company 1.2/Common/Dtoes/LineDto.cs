using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
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
    [DataContract]
    public class LineDto
    {
        [DataMember]
        public int LineId { get; set; }
        [DataMember]
        public string Number { get; set; }
        [DataMember]
        public Status Status { get; set; }

        [DataMember]
        public int PackageId { get; set; }
        [DataMember]
        public PackageDto Package { get; set; }

        [DataMember]
        public int CustomerId { get; set; }
        [DataMember]
        public CustomerDto Customer { get; set; }

        [DataMember]
        public SelectedNumberDto SelectedNumbers { get; set; }

        public virtual IEnumerable<SMSDto> SMSes { get; set; }
        public virtual IEnumerable<CallDto> Calls { get; set; }

    }
}

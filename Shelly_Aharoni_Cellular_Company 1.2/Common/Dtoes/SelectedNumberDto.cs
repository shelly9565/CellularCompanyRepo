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
    public class SelectedNumberDto
    {
        [DataMember]
        public int SelectedNumberId { get; set; }
        [DataMember]
        public string FirstNumber { get; set; }
        [DataMember]
        public string SecondNumber { get; set; }
        [DataMember]
        public string ThirdNumber { get; set; }

        public virtual LineDto Line { get; set; }

    }
}

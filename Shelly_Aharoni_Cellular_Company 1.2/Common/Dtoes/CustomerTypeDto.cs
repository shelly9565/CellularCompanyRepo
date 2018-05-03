using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtoes
{
    public class CustomerTypeDto
    {
        public int CustomerTypeId { get; set; }
        public string TypeName { get; set; }
        public double MinutePrice { get; set; }
        public double SMSPrice { get; set; }

        public virtual IEnumerable<CustomerDto> Customers { get; set; }

    }
}

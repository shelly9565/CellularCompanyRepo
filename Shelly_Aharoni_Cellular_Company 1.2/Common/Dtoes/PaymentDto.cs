using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtoes
{
    public class PaymentDto
    {
        public int PaymentId { get; set; }
        public DateTime Date { get; set; }
        public double TotalPayment { get; set; }
        public int CustomerId { get; set; }
        public CustomerDto Customer { get; set; }
    }
}

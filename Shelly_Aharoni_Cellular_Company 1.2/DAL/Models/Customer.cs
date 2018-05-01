using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public int CallsToCenter { get; set; }

        [ForeignKey("CustomerType")]
        public int? CustomerTypeId { get; set; }
        public CustomerType CustomerType { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Line> Lines { get; set; }

        //public override string ToString()
        //{
        //    return $"FirstName:{FirstName}, LastName:{LastName}";
        //}
    }
}

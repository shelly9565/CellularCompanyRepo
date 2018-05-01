using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SelectedNumber
    {
        [Key]
        public int SelectedNumberId { get; set; }
        public string FirstNumber { get; set; }
        public string SecondNumber { get; set; }
        public string ThirdNumber { get; set; }

        public virtual ICollection<PackageInclude> PackageIncludes { get; set; }

    }
}

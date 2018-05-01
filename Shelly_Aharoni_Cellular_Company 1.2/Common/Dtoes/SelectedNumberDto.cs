using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtoes
{
    public class SelectedNumberDto
    {
        public int SelectedNumberId { get; set; }
        public string FirstNumber { get; set; }
        public string SecondNumber { get; set; }
        public string ThirdNumber { get; set; }

        public virtual ICollection<PackageIncludeDto> PackageIncludes { get; set; }

    }
}

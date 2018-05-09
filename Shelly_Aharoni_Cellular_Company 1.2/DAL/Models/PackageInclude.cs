using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class PackageInclude
    {
        [Key, ForeignKey(nameof(Line))]
        public int PackageIncludeId { get; set; }
        public string IncludeName { get; set; }
        public int MaxMinute { get; set; }
        public double FixedPrice { get; set; }
        public double DiscountPrecentage { get; set; }
        public string MostCalledNumber { get; set; }
        public bool InsideFamilyCalls { get; set; }

        [ForeignKey(nameof(SelectedNumber))]
        public int? FavoriteNumbersId { get; set; }
        public SelectedNumbers SelectedNumber { get; set; }
        
        public Line Line { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtoes
{
    public class PackageIncludeDto
    {
        public int PackageIncludeId { get; set; }
        public string IncludeName { get; set; }
        public int? MaxMinute { get; set; }
        public double? FixedPrice { get; set; }
        public double? DiscountPrecentage { get; set; }
        public string MostCalledNumber { get; set; }
        public bool InsideFamilyCalls { get; set; }
        public int? FavoriteNumbersId { get; set; }
        public SelectedNumberDto SelectedNumber { get; set; }
        public int PackageId { get; set; }
        public PackageDto Package { get; set; }
    }
}

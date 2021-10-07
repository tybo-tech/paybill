using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WaterBillAppCore.Models
{
    public class Setting
    {
        [Key]
        public int SettingId { get; set; }

   

        [Display(Name = "Range Start (kilolitre)")]
        [Column(TypeName = "decimal(18, 2)")]
        public double RangeStart { get; set; }


        [Display(Name = "Range Start (kilolitre)")]
        [Column(TypeName = "decimal(18, 2)")]
        public double RangeFinish { get; set; }


        [Display(Name = "Water charge per kilolitre (Rands)")]
        [Column(TypeName = "decimal(18, 2)")]
        public double ChargeRate { get; set; }
    }
}

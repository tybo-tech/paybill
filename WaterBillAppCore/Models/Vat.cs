using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WaterBillAppCore.Models
{
    public class Vat
    {

        [Key]
        public int SettingId { get; set; }

        [Display(Name = "Vat percentage (Rands)")]
        [Column(TypeName = "decimal(18, 2)")]
        public double VatPercetage { get; set; }

     

    }
}

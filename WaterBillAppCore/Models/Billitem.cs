using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WaterBillAppCore.Models
{
    public class Billitem
    {
        [Key]
        public int BillItemId { get; set; }


        [Column(TypeName =  "nvarchar(50)")]
        public string ItemName { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        public string MeterNo { get; set; }



        [Column(TypeName = "decimal(18, 2)")]
        public double PrevReading { get; set; }



        [Column(TypeName = "decimal(18, 2)")]
        public double CurrentReading { get; set; }





        [Column(TypeName = "decimal(18, 2)")]
        public double Amount { get; set; }


        [Column(TypeName = "int")]
        public int Usage { get; set; }



    }
}

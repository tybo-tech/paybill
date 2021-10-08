using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WaterBillAppCore.Models
{
    public class Bill
    {
        [Display(Name = "Bill Number")]
        [Key]

        public int BillId { get; set; }


        [Column(TypeName =  "int")]
        public int CustomerId { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        public string CustomerName { get; set; }


        [Column(TypeName =  "nvarchar(50)")]
        public string CustomerAddress { get; set; }


        [Column(TypeName =  "nvarchar(50)")]
        public string CustomerPhone { get; set; }


        [Column(TypeName =  "nvarchar(500)")]
        public string CustomerEmail { get; set; }


        [Column(TypeName =  "nvarchar(50)")]
        public string BillNo { get; set; }


        [Column(TypeName = "decimal(18, 2)")]
        public double Amount { get; set; }



        [Column(TypeName = "decimal(18, 2)")]
        public double AmountPaid { get; set; }



        [Column(TypeName = "datetime2")]
        public DateTime PaymentDate { get; set; }


        [Column(TypeName = "datetime2")]
        public DateTime DueDate { get; set; }



        [Column(TypeName = "datetime2")]
        [Display(Name = "Date Created")]
        public DateTime CreatedDate { get; set; }


        [Column(TypeName = "datetime2")]
        public DateTime LastModifiedDate { get; set; }


        [Column(TypeName =  "nvarchar(50)")]
        [Display(Name = "Status")]
        public string BillStatus { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Description { get; set; }


        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Previous meter reading")]

        public double PrevReading { get; set; }



        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Current meter reading")]

        public double CurrentReading { get; set; }



        [Column(TypeName = "decimal(18, 2)")]
        public double Usage { get; set; }


        [Column(TypeName = "nvarchar(3000)")]
        public string PhotoUrl { get; set; }


        [Column(TypeName = "decimal(18, 2)")]
        public double Vat { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }


    }
}

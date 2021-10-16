using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WaterBillAppCore.Models
{
    public class Query
    {
        [Key]
        public int QueryId { get; set; }
       
        [Column(TypeName =  "nvarchar(3000)")]
        public string Description { get; set; }


        [Column(TypeName =  "nvarchar(100)")]
        [Display(Name = "Query Category")]
        public string Category { get; set; }




        [Column(TypeName = "nvarchar(300)")]
        public string CustomerId { get; set; } 
        
        
        [Column(TypeName = "nvarchar(500)")]
        public string AddressUrl { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }


        [Column(TypeName = "nvarchar(2000)")]
        [Display(Name = "Customer Address")]
        public string CustomerAddress { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "Customer Phone")]
        public string CustomerPhone { get; set; }


        [Column(TypeName = "nvarchar(500)")]
        [Display(Name = "Customer Email")]
        public string CustomerEmail { get; set; }



        [Column(TypeName = "nvarchar(500)")]
        [Display(Name = "Query Status")]
        public string QueryStatus { get; set; }

        [Column(TypeName = "datetime2")]
        [Display(Name = "Create Date")]
        public DateTime CreateDate { get; set; }


        [Column(TypeName = "datetime2")]
        [Display(Name = "Accepted Date")]
        public DateTime AcceptedDate { get; set; }



        [Column(TypeName = "datetime2")]
        [Display(Name = "Closed Date")]
        public DateTime ClosedDate { get; set; }


        [Column(TypeName = "datetime2")]
        [Display(Name = "Last Modified Date")]
        public DateTime LastModifiedDate { get; set; }



        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "Customer Account Number")]
        public string AccountNumber { get; set; }


    }
}

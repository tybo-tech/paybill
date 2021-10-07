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


        [Column(TypeName =  "nvarchar(50)")]
        public string Category { get; set; }




        [Column(TypeName = "int")]
        public int CustomerId { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        public string CustomerName { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        public string CustomerAddress { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        public string CustomerPhone { get; set; }


        [Column(TypeName = "nvarchar(500)")]
        public string CustomerEmail { get; set; }



        [Column(TypeName = "nvarchar(500)")]
        public string QueryStatus { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }


        [Column(TypeName = "datetime2")]
        public DateTime AcceptedDate { get; set; }



        [Column(TypeName = "datetime2")]
        public DateTime ClosedDate { get; set; }


        [Column(TypeName = "datetime2")]
        public DateTime LastModifiedDate { get; set; }


    }
}

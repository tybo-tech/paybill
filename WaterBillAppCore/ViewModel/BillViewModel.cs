using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WaterBillAppCore.ViewModel
{
    public class BillViewModel
    {


        public int CustomerId { get; set; }


        public string CustomerName { get; set; }


        public string CustomerAddress { get; set; }


        public string CustomerPhone { get; set; }


        public string CustomerEmail { get; set; }


        public string BillNo { get; set; }


        public double Amount { get; set; }



        public double AmountPaid { get; set; }



        public DateTime PaymentDate { get; set; }


        public DateTime DueDate { get; set; }



        public DateTime CreatedDate { get; set; }


        public DateTime LastModifiedDate { get; set; }


        [Display(Name = "Status")]
        public string BillStatus { get; set; }

        public string Description { get; set; }


        [Display(Name = "Previous meter reading")]

        public double PrevReading { get; set; }



        [Display(Name = "Current meter reading")]

        public double CurrentReading { get; set; }



        public double Usage { get; set; }

        public IFormFile Photo { get; set; }

    }
}

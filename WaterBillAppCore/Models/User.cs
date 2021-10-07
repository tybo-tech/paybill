using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WaterBillAppCore.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }


        [Column(TypeName =  "nvarchar(50)")]
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }



        [Column(TypeName =  "nvarchar(50)")]
        public string LastName { get; set; }


        [Column(TypeName =  "nvarchar(50)")]
        public string UserEmail { get; set; }


        [Column(TypeName =  "nvarchar(15)")]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string HomeAddress { get; set; }
        [Column(TypeName =  "nvarchar(50)")]
        public string Password { get; set; }
        [Column(TypeName =  "nvarchar(50)")]
        public string UserType { get; set; }
        [Column(TypeName =  "nvarchar(50)")]
        public string CreatedDate { get; set; }
        [Column(TypeName =  "nvarchar(50)")]
        public string LastModifiedDate { get; set; }
        [Column(TypeName =  "nvarchar(50)")]
        public string UserStatus { get; set; }

        [Column(TypeName = "nvarchar(2000)")]
        public string UserAddres { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string MeterNo { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string AccountNumber { get; set; }
    }
}

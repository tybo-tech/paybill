using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WaterBillAppCore.Models
{
    // Add profile data for application users by adding properties to the AppUser class
    public class AppUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(500)")]
        [Display(Name = "Home Address")]
        public string HomeAddress { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "Password")]
        public string Password { get; set; }



        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "Created Date")]
        public string CreatedDate { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "Last Modified Date")]
        public string LastModifiedDate { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "User Status")]
        public string UserStatus { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(200)")]
        [Display(Name = "Meter No")]
        public string MeterNo { get; set; }


        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "Customer Account Number")]
        public string AccountNumber { get; set; }


        [PersonalData]
        [Column(TypeName = "nvarchar(500)")]
        public string AddressUrl { get; set; }




    }
}

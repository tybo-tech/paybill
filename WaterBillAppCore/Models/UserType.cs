using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WaterBillAppCore.Models
{
    public class UserType
    {
        [Key]
        public int QueryTypeId { get; set; }

        [Display(Name = "User Type")]
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }
    }
}

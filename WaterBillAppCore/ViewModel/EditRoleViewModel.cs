using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WaterBillAppCore.ViewModel
{
    public class EditRoleViewModel
    {

      
        [Required]
        public string Id { get; set; }

        [Required]
        public string RoleName { get; set; }


        public List<string> Users { get; set; }

        public EditRoleViewModel()
        {
            Users = new List<string>();
        }


    }
}

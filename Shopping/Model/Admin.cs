using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Model
{
    public class Admin
    {

        public int id { get; set; }


        [Required]
        [EmailAddress]
        public string admin_email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string admin_password { get; set; }

        [Display(Name = "Remeber Me ")]
        public bool RememberMe { get; set; }
    }
}

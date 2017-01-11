using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace scLInq.WebUI.Models
{
    public class UserM
    {
        [Required(ErrorMessage = "Please Provide Username", AllowEmptyStrings = false)]
        [Display(Name = "UserName")]
        [StringLength(50)]
        [DataType(DataType.Text)]

        public string Name { get; set; }

        [Required(ErrorMessage = "Please Provide Password", AllowEmptyStrings = false)]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6)]
        public string Password { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace scLInq.WebUI.Models
{
    public class FAQM
    {
        [Required(ErrorMessage = "Question Can not be left blank.", AllowEmptyStrings = false)]
        [Display(Name = "Question")]
        [StringLength(100)]
        [DataType(DataType.Text)]

        public string Question { get; set; }

        [Required(ErrorMessage = "Answer Can not be left blank.", AllowEmptyStrings = false)]
        [Display(Name = "Answer")]
        [AllowHtml]
        [UIHint("tinymce_full")]
        public string Answer { get; set; }
    }
}
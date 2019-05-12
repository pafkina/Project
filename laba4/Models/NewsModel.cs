using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;        
using System.Linq;
using System.Web;

namespace laba4.Models
{
    public partial class NewsModel 
    {
        public int NewsID { get; set; }

        [Required(ErrorMessage = "This field is Required")]
        public string Locality { get; set; }

        [Required(ErrorMessage = "This field is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is Required")]
        public string Description { get; set; }
    }
}
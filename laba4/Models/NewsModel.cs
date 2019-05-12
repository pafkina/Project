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

        [Required(ErrorMessage = "Enter Locality")]
        public string Locality { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Description")]
        public string Description { get; set; }
    }
}
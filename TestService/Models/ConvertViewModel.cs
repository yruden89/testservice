using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestService.Models
{
    public class ConvertViewModel
    {
        [Required]
        public string From { get; set; }


        [Required]
        public string To { get; set; }

        [Required]
        public decimal Amount { get; set; }
    }
}
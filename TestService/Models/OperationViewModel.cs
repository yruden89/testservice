using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestService.Providers.CommonTypes;

namespace TestService.Models
{
    public class OperationViewModel
    {
        [Required]
        public decimal FirstNumber { get; set; }

        [Required]
        public decimal SecondNumber { get; set; }

        [Required]
        public OperationType OperationType { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication1.Models
{
    public class Client
    {
        [Required]
        public int Id {get;set;}

        [Required]
        [DataType(DataType.Text)]
        [StringLength(maximumLength:200, MinimumLength=5)]
        public string Name{get;set;}

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date {get;set;}

        [Required]
        [DataType(DataType.Currency)]
        public double Salary { get; set; }


    }
}
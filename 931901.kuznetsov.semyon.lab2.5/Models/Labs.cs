using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _931901.kuznetsov.semyon.lab2._5.Models
{
    public class Labs
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter name")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter address")]
        [Display(Name = "Address")]
        public string Address { get; set; }
    }
}

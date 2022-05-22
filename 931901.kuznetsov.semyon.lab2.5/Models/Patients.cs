using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace _931901.kuznetsov.semyon.lab2._5.Models
{
    public class Patients
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Full name")]
        [Display(Name = "Full name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter disease")]
        [Display(Name = "Disease")]
        public string Disease { get; set; }

        [Required(ErrorMessage = "Enter phone")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}

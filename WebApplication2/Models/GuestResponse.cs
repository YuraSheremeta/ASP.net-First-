using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Pleace enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter uour email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter your mobile phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Pleace specify wheather you will attend")]
        public bool? WillAttend { get; set; }
    }
}

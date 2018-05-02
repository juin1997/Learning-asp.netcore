using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace firstmvc.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter you email address")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter you phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend the party")]
        public bool? WillAttend { get; set; }
    }
}

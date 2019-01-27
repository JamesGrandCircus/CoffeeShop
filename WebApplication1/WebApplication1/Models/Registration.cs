using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Registration
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MinLength(2)]
        //[DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        public string LastName { get; set; }
        [Required]
        [MinLength(6)]
        public string EmailAddress { get; set; }
        [Required]
        [MinLength(10)]
        public string PhoneNumber { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }


    }
}
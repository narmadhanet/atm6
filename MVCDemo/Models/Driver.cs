using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDemo.Models
{
    public class Driver
    {
       
        public int Id { get; set; }

     
        [Required(ErrorMessage ="Please enter Name eg : John")]
        [StringLength(30,MinimumLength =3)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Compare("Email")]
        public string ReTypeEmail { get; set; }

       [DisplayName("Mobile Number")]
        public string Phone { get; set; }
        
        [RegularExpression("^[0-9]{5}$")]
        public string LicenseID { get; set; }

        [Range(18,30)]
        public string Age { get; set; }

        
        public string Address { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfExpiry { get; set; }
    }
}
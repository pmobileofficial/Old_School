using Old_School.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_School.Data.DTOs
{
    public class StudentToAddDto
    {
      
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "First Name must be between 3 to 150 characters")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 to 150 characters")]
        public string LastName { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }
               
        [Required ]
        [StringLength(100, MinimumLength = 3, ErrorMessage ="School Name must be between 3 to 150 characters")]
        public string SchoolName { get; set; }


        [StringLength(200, ErrorMessage = "Tell Us About Yourself")]
        public string About { get; set; }

        public Address Address { get; set; }

        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password does not match!")]
        public string ConfirmPassword { get; set; }
    }
}

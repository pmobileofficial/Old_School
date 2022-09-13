using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;
using Old_School.Data;
using System.ComponentModel.DataAnnotations;


namespace Old_School.Data.Data.Models
{
    public class Teacher : IdentityUser
    {

        public Constants.Titles Title { get; set; } // not very sure of this property
        public string? ProfileUrl { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "First Name must be between 3 to 150 characters")]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 to 150 characters")]
        public string? LastName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "School Name must be between 3 to 150 characters")]
        public string? SchoolName { get; set; }
      
        [Required]
        [StringLength(100, ErrorMessage ="Enter Position")]
        public string? Position { get; set; }

        [StringLength(200, ErrorMessage ="Tell Us About Yourself")]
        public string? About { get; set; }
         public string? SchoolId { get; set; }
        public School? School { get; set; }               
        public DateTime StartYear { get; set; }
        public DateTime EndYear { get; set; }
        public Address? Address { get; set; }       
    
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Old_School.Data.Data.Models
{
    public class Student : IdentityUser
    {
        public Constants.Titles Title { get; set; }

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

        [StringLength(200, ErrorMessage = "Tell Us About Yourself")]
        public string? About { get; set; }

        [Required]       
        public School? School { get; set; }
        public string? SchoolId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; }
        public Address? Address { get; set; }

        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

     
    }
}

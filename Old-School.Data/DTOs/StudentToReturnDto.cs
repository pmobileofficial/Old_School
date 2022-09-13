using Old_School.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_School.Data.DTOs
{
    public class StudentToReturnDto
    {
      
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
               
        public string SchoolName { get; set; }


        public string About { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; }
        public Address Address { get; set; }

        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

      
    }
}

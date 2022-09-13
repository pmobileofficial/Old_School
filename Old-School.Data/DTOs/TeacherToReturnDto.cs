using Old_School.Data.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_School.Data.DTOs
{
    public class TeacherToReturnDto
    {
       
       
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Position { get; set; }

        public string SchoolName { get; set; }
   
        public string About { get; set; }

        public DateTime StartYear { get; set; }

        public DateTime EndYear { get; set; }
        public string Address { get; set; }
     
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

    
    }
}

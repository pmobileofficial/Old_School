using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_School.Data.DTOs
{
    public class UpdateSchoolDto
    {
        public string SchoolName { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

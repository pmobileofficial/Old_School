using Old_School.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_School.Data.DTOs
{
    public class SchoolToReturnDto : BaseEntity
    {
        public string SchoolName { get; set; }
        public string Address { get; set; }
      
    }
}

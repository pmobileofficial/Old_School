using Old_School.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_School.Data.Data
{
    public class School : BaseEntity
    {
       
        public string? Name { get; set; }
        
        public string? AddressId { get; set; }
        public Address? Address { get; set; }

        public string? Logo { get; set; }

   //     public Constants.SchoolType Type { get; set; }

        public ICollection<Student>? Students { get; set; }
        public ICollection<Teacher>? Teachers { get; set; }
       
    }
}

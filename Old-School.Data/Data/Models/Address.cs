using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_School.Data.Data.Models
{
    [Table(name: "Addresses")]
    public class Address : BaseEntity
    {
        public string? StreetAddress { get; set; }
        public string? City { get; set; }

        public string? State { get; set; }
        public string? Country { get; set; }
       
        
    }
}

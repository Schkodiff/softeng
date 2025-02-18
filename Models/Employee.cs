using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _228.Models
{
    class Employee : Person
    {
        public int Id { get; set; }
        public int Phone_number { get; set; }
        [MaxLength(150)]
        public string Password { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _228.Models
{
    public class Person
    {
        [MaxLength(150)]
        public string Full_name { get; set; }
        public DateTime  Birthdate { get; set; }
    }
}

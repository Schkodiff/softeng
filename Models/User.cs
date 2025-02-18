using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _228.Class
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
    }
}

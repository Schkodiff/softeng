using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace _228.Class
{
    public class Activity
    {
        public int Id { get; set; }
        [MaxLength(512)]
        public string Descr { get; set; }
        public int UserId { get; set; }
        public int User { get; set; }


    }
}

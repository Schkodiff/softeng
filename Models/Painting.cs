using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace _228.Class
{
    class Painting
    {
        public int Id { get; set; }

        [MaxLength(150)]
        public string Name { get; set; }
        public DateTime Year_of_painting { get; set; }
        public int Cost { get; set; }

        //public location Location { get; set; }
        //public status Status { get; set; }
    }
}

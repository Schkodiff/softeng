using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace _228.Class
{
    public class Context : DbContext
    {
        public Context() : base("myCS") { }

        public DbSet<User> Users { get; set; }

        public DbSet<Activity> Activities { get; set; }
    }
}

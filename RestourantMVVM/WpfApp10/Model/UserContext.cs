using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp10.Model;

namespace WpfApp10
{
    class UserContext:DbContext
    {
        public UserContext():base("DefaultConnection")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Menu> RestourantMenu { get; set; }
    }
}

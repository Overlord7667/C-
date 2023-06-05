using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoteatr
{
    class KinoteatrContext:DbContext
    {
        public KinoteatrContext() : base("DefaultConnection")
        {

        }
        public DbSet<Film> Films { get; set; }
        public DbSet<KinoteatrFilm> Kinoteatrs { get; set; }
    }
}

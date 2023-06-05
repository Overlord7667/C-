using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Magazin
{
    public partial class MagazinDB : DbContext
    {
        public MagazinDB()
            : base("name=MagazinDB")
        {
        }
        public DbSet<MagazinModel> MagazinModels { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

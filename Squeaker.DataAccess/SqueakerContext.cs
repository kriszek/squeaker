using Squeaker.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squeaker.DataAccess
{
    public class SqueakerContext : DbContext
    {
        public DbSet<Squeak> Squeaks { get; set; }
        public DbSet<SqueakComment> SqueakComments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

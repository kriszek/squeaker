using Microsoft.AspNet.Identity.EntityFramework;
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
    public class SqueakerContext : IdentityDbContext<ApplicationUser>
    {
        public SqueakerContext() : base("DefaultConnection")
        {

        }

        public static SqueakerContext Create()
        {
            return new SqueakerContext();
        }

        public DbSet<Squeak> Squeaks { get; set; }
        public DbSet<SqueakComment> SqueakComments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}

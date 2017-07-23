using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Tutorials
{
    public class SchoolDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Course> Courses { get; set; }

        public SchoolDBContext() : base("name=SchoolDBConnectionString")
        {
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());

            // Turn off DB initializer
            //Database.SetInitializer<SchoolDBContext>(null);

            // Set Seed data on DB initialization
            Database.SetInitializer(new SchoolDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure Student Entity
            modelBuilder.Configurations.Add(new StudentEntityConfiguration());
        }
    }
}

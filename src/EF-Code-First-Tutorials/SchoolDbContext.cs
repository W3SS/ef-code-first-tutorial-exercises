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
            Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure default DB schema
            // modelBuilder.HasDefaultSchema("Admin");

            // Map entity to table
            //modelBuilder.Entity<Student>().ToTable("StudentInfo");
            //modelBuilder.Entity<Standard>().ToTable("StandardInfo", "dbo");
        }
    }
}

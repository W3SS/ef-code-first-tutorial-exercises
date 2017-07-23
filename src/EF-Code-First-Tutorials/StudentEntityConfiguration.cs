using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Tutorials
{
    // Responsible for configuring the Student Entity via Fluent API in Context class
    public class StudentEntityConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentEntityConfiguration()
        {
            // Assign table name of Student Info
            this.ToTable("StudentInfo");

            // Assign as Primary key since Property name does not meet default EF convention
            //this.HasKey<int>(s => s.StudentKey);

            // Assign DateOfBirth to 3rd column in DB with a column data type of Date/Time
            this.Property(p => p.DateOfBirth)
                .HasColumnName("dob")
                .HasColumnOrder(3)
                .HasColumnType("datetime2");

            // 1. Set maximum length of this property to 50 chars.
            // 2. Make StudentName a concurrency token
            // This means that the DB value of this field will be checked for changes, and it will
            // throw an error if changes were made prior or in tandem with the current DB transaction.
            this.Property(p => p.StudentName)
                .HasMaxLength(50);
                //.IsConcurrencyToken();

            // Set up many-to-many relationship between Student and Course
            // Set StudentId and CourseId field names on junction object
            // Set table name for junction object
            /*this.HasMany<Course>(s => s.Courses)
                .WithMany(c => c.Students)
                .Map(cs =>
                {
                    cs.MapLeftKey("StudentId");
                    cs.MapRightKey("CourseId");
                    cs.ToTable("StudentCourse");
                });*/
        }
    }
}

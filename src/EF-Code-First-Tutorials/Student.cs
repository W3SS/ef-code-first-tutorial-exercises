using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Tutorials
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        public string StudentName { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        // Foreign Key Property -- must be nullable type to avoid INSERT exception
        public int? StandardId { get; set; }

        // Navigation Property
        public virtual Standard Standard { get; set; }

        // Collection navigation property - one student => many courses
        public virtual ICollection<StudentCourse> Courses { get; set; }

        public Student()
        {
            Courses = new List<StudentCourse>();
        }
    }
}

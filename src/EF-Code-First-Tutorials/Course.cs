using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Tutorials
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        // Collection navigation property - one course => many students
        public virtual ICollection<StudentCourse> Students { get; set; }

        public Course()
        {
            Students = new List<StudentCourse>();
        }
    }
}

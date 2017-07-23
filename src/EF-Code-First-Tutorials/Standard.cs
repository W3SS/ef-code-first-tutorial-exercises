﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Tutorials
{
    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public string Description { get; set; }

        public ICollection<Student> Students { get; set; }

        public Standard()
        {
            Students = new List<Student>();
        }
    }
}

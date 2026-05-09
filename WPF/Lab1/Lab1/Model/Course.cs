using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Model
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public int TeacherId { get; set; }
        public string Result { get; set; } 

        public Teacher Teacher { get; set; }
        public List<Result> Results { get; set; } = new();
    }

}

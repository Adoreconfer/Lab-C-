using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Lab1.Model
{
    public class Result
    {
        public int GradeId { get; set; }

        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public string GradeValue { get; set; }
        public DateTime GradeDate { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }

}

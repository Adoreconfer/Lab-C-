using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Lab1.Model
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public int UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public User User { get; set; }
        public List<Course> Courses { get; set; } = new();
    }

}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab1.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public int UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AlbumNumber { get; set; }
        public string Gender { get; set; }
        public string GroupName { get; set; }

        public User User { get; set; }
        public Group Group { get; set; }
        public List<Result> Results { get; set; } = new();
    }

}

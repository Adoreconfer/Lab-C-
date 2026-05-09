using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Model
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }

        public List<Student> Students { get; set; } = new();
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public Admin Admin { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Model
{
    public class Admin
    {
        public int AdminId { get; set; }
        public int UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User User { get; set; }
    }

}

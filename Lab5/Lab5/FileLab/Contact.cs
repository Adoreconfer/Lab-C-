using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Task
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Contact(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"ID: {Id}\tImię i nazwisko: {Name}\tEmail: {Email}";
        }
    }
}

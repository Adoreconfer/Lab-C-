using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.FileLab
{
    internal class Country
    {
        public string id { get; set; }
        public string value { get; set; }

        public Country(string id, string value)
        {
            this.id = id;
            this.value = value;
        }

        public override string ToString()
        {
            return $"Country: id: {id}, value: {value}";
        }
    }
}

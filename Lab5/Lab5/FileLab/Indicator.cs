using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.FileLab
{
    internal class Indicator
    {
        public string id { get; set; }
        public string value { get; set; }

        public Indicator(string id, string value)
        {
            this.id = id;
            this.value = value;
        }

        public override string ToString()
        {
            return $"Indicator: id: {id}, value: {value}";
        }
    }
}

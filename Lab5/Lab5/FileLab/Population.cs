using Lab5.Task;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Lab5.FileLab
{
    internal class Population
    {
        public Indicator indicator { get; set; }
        public Country country { get; set; }
        public string value { get; set; }
        [JsonPropertyName("decimal")]
        public string decimalValue { get; set; }
        public string date { get; set; }

        public Population() { }

        public override string ToString()
        {
            return $"{indicator}\n{country},\nvalue: {value}, decimal: {decimalValue}, date: {date}";
        }

        public void View() {
            Console.WriteLine(ToString());
        }
    }
}

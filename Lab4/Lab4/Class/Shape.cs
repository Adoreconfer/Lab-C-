using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Class
{
    class Shape
    {
        public float X { set; private get; }
        public float Y { set; private get; }
        public float Height { set; private get; }
        public float Width { set; private get; }

        public virtual void Draw() {
            Console.Write("Rysuję: ");  
        }
    }
}

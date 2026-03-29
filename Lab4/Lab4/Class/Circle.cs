using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Class
{
    class Circle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Koło");
        }
    }
}

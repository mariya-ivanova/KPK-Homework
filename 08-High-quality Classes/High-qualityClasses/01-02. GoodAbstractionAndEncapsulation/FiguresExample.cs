using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02.GoodAbstractionAndEncapsulation
{
    class FiguresExample
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);

            Console.WriteLine(circle.ToString());

            Rectangle rect = new Rectangle(2, 3);

            Console.WriteLine(rect.ToString());
        }
    }
}

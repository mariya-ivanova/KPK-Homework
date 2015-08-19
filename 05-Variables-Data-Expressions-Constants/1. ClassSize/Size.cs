/* Refactor the following code to use proper variable naming and simplified expressions: */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ClassSize
{
    public class Size
    {
        public double width, height;
        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Size GetRotatedSize(Size size, double angleOfRotation)
        {
            double newWidth = Math.Abs(Math.Cos(angleOfRotation)) * size.width +
                    Math.Abs(Math.Sin(angleOfRotation)) * size.height;

            double newHeight = Math.Abs(Math.Sin(angleOfRotation)) * size.width +
                    Math.Abs(Math.Cos(angleOfRotation)) * size.height;

            return new Size(newWidth, newHeight);
        }

        static void Main(string[] args)
        {
            Size size = new Size(5, 4);
            Size newSize = GetRotatedSize(size, Math.PI/4);
            Console.WriteLine("New width: {0:F2}", newSize.width);
            Console.WriteLine("New height: {0:F2}", newSize.height);
        }

    }

}

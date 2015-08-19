using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Distance in the 2D space = {0:f2}",
                Geometry.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                Geometry.CalcDistance3D(5, 2, -1, 3, -6, 4));

            double width = Geometry.CalcDistance2D(3, 0, 0, 0); // Width: 3
            double height = Geometry.CalcDistance2D(0, 0, 0, 4); // Height: 4
            double depth = Geometry.CalcDistance2D(0, 0, 0, 5); // Depth: 5

            var shape = new Shape(width, height, depth);
            Console.WriteLine("Shape \nwidth: {0:f2}, \nheight: {1:f2}, \ndepth {2:f2}", width, height, depth);
            Console.WriteLine("volume: {0:f2}", shape.CalcVolume());
            Console.WriteLine("diagonal XY: {0:f2}", shape.CalcDiagonalXY());
            Console.WriteLine("diagonal XZ: {0:f2}", shape.CalcDiagonalXZ());
            Console.WriteLine("diagonal YZ: {0:f2}", shape.CalcDiagonalYZ());
            Console.WriteLine("diagonal XYZ: {0:f2}", shape.CalcDiagonalXYZ());
            Console.WriteLine();

            Console.WriteLine("File extensions:");
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));
            Console.WriteLine();

            Console.WriteLine("File names:");
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));
        }
    }
}

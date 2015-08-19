using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CohesionAndCoupling
{
    class Shape
    {
        private double width;
        private double height;
        private double depth;

        internal Shape(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        internal double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                Validator.ValidateIfNegative(value, "Width must be a positive number");
                this.width = value;
            }
        }

        internal double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                Validator.ValidateIfNegative(value, "Height must be a positive number");
                this.height = value;
            }
        }

        internal double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                Validator.ValidateIfNegative(value, "Depth must be a positive number");
                this.depth = value;
            }
        }

        internal double CalcVolume()
        {
            double volume = this.Depth * this.Height * this.Depth;
            return volume;
        }

        internal double CalcDiagonalXYZ()
        {
            double diagonal = Geometry.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return diagonal;
        }

        internal double CalcDiagonalXY()
        {
            double diagonal = Geometry.CalcDistance2D(0, 0, this.Width, this.Height);
            return diagonal;
        }

        internal double CalcDiagonalXZ()
        {
            double diagonal = Geometry.CalcDistance2D(0, 0, this.Width, this.Depth);
            return diagonal;
        }

        internal double CalcDiagonalYZ()
        {
            double diagonal = Geometry.CalcDistance2D(0, 0, this.Height, this.Depth);
            return diagonal;
        }
    }
}

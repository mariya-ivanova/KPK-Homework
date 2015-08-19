using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02.GoodAbstractionAndEncapsulation
{
    class Rectangle : Figure
    {
        private double width;
        private double height;

        internal Rectangle(double width, double height)
            : base()
        {
            this.Width = width;
            this.Height = height;
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

        internal override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        internal override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}

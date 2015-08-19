using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02.GoodAbstractionAndEncapsulation
{
    class Circle : Figure
    {
        private double radius;

        internal Circle(double radius)
            : base()
        {
            this.Radius = radius;
        }

        internal double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                Validator.ValidateIfNegative(value, "Radius must be a positive double value");
                this.radius = value;
            }
        }

        internal override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }

        internal override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }
    }
}

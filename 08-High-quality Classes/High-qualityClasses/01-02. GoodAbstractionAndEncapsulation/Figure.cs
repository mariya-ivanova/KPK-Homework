using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02.GoodAbstractionAndEncapsulation
{
    abstract class Figure
    {
        internal Figure()
        {
        }

        internal abstract double CalcPerimeter();

        internal abstract double CalcSurface();

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine("I am a " + this.GetType().Name);
            result.AppendFormat("My perimeter is {0:f2}", this.CalcPerimeter());
            result.AppendLine();
            result.AppendFormat("My surface is {0:f2}.", this.CalcSurface());

            return result.ToString();
        }
    }
}

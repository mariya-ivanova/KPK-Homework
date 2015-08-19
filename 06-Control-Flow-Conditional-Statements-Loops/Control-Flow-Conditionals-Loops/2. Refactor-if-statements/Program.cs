using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Refactor_if_statements
{
    class Program
    {
        private const int MinX = 0;
        private const int MaxX = 100;
        private const int MinY = 0;
        private const int MaxY = 100;

        static void Main(string[] args)
        {
            //1.
            Potato potato = new Potato();

            if (potato == null)
            {
                throw new ArgumentNullException("Potato does not have a value.");
            }

            if (potato.HasBeenPeeled && !potato.IsRotten)
            {
                Cook(potato);
            }


            //2.
            bool shouldVisitCell = true;
            int x = 5;
            int y = 10;

            if ((MinX <= x && x <= MaxX) && (MinY <= y && y <= MaxY) && shouldVisitCell)
            {
                VisitCell();
            }


        }

        public static void Cook(Potato potato)
        {
        }

        public static void VisitCell()
        {
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ClassChef
{

    public class Chef
    {
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl = GetBowl();

            Peel(potato);
            Peel(carrot);

            Cut(potato);
            Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);

            Console.WriteLine("The meal is ready :)\n");
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private static void Cut(IIngredient ingredient)
        {
            Console.WriteLine("{0} is cut", ingredient.GetType().Name);
        }

        private static void Peel(IIngredient ingredient)
        {
            Console.WriteLine("{0} is peeled", ingredient.GetType().Name);
        }

        static void Main(string[] args)
        {
            Chef mimi = new Chef();
            mimi.Cook();
        }
    }

}

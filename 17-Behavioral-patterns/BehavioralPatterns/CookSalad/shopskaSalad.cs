using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookSalad
{
    public class ShopskaSalad : Salad
    {
        public override void CutIngredients(List<IIngredient> ingredients)
        {
            foreach(var ingredient in ingredients)
            {
                Console.WriteLine("{0} is cut in cubes", ingredient.GetType().Name);
            }
        }

        public override void AddSpices()
        {
            Console.WriteLine("Added salt, vinegret and olive oil");
        }
    }
}

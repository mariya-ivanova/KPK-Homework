using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookSalad
{
    public class SelskaSalad : Salad
    {
        public override void CutIngredients(List<IIngredient> ingredients)
        {
            foreach(var ingredient in ingredients) 
            {
                Console.WriteLine("{0} is cut in slices", ingredient.GetType().Name);            
            }
        }
        public override void AddSpices()
        {
            Console.WriteLine("Added salt and olive oil");
        }
    }
}

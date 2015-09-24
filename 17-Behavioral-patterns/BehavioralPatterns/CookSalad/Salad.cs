using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookSalad
{
    public abstract class Salad
    {

        public void PrepareRecipe(List<IIngredient> ingredients)
        {
            CutIngredients(ingredients); 
            AddSpices();
        }

        public abstract void CutIngredients(List<IIngredient> ingredients);
        public abstract void AddSpices();
    }
}

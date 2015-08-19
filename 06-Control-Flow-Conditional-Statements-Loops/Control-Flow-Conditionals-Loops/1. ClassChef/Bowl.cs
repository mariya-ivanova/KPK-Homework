using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ClassChef
{
    public class Bowl
    {
        public Bowl()
        {
            this.Ingredients = new List<IIngredient>();
        }

        public ICollection<IIngredient> Ingredients { get; set; }

        public void Add(IIngredient ingredient)
        {
            this.Ingredients.Add(ingredient);
        }

    }
}

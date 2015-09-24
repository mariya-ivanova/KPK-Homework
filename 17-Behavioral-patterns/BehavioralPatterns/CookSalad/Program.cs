using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookSalad
{
    class Program
    {
        static void Main(string[] args)
        {
            Tomato tomato = new Tomato();
            Pepper pepper = new Pepper();
            Cheese cheese = new Cheese();
            Mushrooms mushrooms = new Mushrooms();
            Onion onion = new Onion();

            List<IIngredient> ingredientsForSelskaSalad = new List<IIngredient>();
            ingredientsForSelskaSalad.Add(tomato);
            ingredientsForSelskaSalad.Add(pepper);
            ingredientsForSelskaSalad.Add(onion);
            ingredientsForSelskaSalad.Add(cheese);
            ingredientsForSelskaSalad.Add(mushrooms);

            SelskaSalad selskaSalad = new SelskaSalad();
            Console.WriteLine("Selska salad preparation:\n");

            selskaSalad.PrepareRecipe(ingredientsForSelskaSalad);
            Console.WriteLine();

            Cucumber cucumber = new Cucumber();
            List<IIngredient> ingredientsForShopskaSalad = new List<IIngredient>();

            ingredientsForShopskaSalad.Add(cucumber);
            ingredientsForShopskaSalad.Add(tomato);
            ingredientsForShopskaSalad.Add(pepper);
            ingredientsForShopskaSalad.Add(onion);
            ingredientsForShopskaSalad.Add(cheese);

            ShopskaSalad shopskaSalad = new ShopskaSalad();
            Console.WriteLine("Shopska salad preparation:\n");
            shopskaSalad.PrepareRecipe(ingredientsForShopskaSalad);
        }
    }
}

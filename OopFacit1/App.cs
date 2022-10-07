using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFacit1
{
    public class App
    {
        public void ShowSubMenu(List<Dish> lunchList, string rubrik, DishType dishType)
        {
            Console.WriteLine(rubrik);
            foreach (var dish in lunchList)
            {
                if (dish.DishType == dishType)
                    Console.WriteLine($"{dish.Name} Antal kalorier:{dish.Calories}   {dish.Price}Kr");
            }
        }

        public void Run()
        {
            var lunchList = new List<Dish>();
            var dish1 = new Dish("Pannkakor", 50, 10, DishType.Vegetarian);
            var dish2 = new Dish("Köttbullar", 70, 30, DishType.Meat);
            var dish3 = new Dish("Burgare", 100, 50, DishType.Meat);

            lunchList.Add(dish1);
            lunchList.Add(dish2);
            lunchList.Add(dish3);

            ShowSubMenu(lunchList, "VEGETARISK", DishType.Vegetarian);
            ShowSubMenu(lunchList, "KÖTT", DishType.Meat);
            ShowSubMenu(lunchList, "VEGANSK", DishType.Vegan);

        }
    }
}

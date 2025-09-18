using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu.Core.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Grams { get; set; }
        public DishCategory Category { get; set; }
        public  Country country { get; set; }

    }

    public enum DishCategory
    {
        Breakfast,
        Salad,
        MainCourse,
        Dessert,
        Drink
    }
    public enum Country
    {
        Russian,
        Italian,
        Eastern
    }

}

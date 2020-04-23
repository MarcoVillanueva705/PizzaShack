using System.Collections.Generic;
using pizza_shack.Models;

namespace pizza_shack.Mock
{
    public static class fakeDb
    {
        public static List<string> MyValues = new List<string>() {"value1", "value2", "value3"};

        public static Dictionary<string, Topping> AvailToppings = new Dictionary<string, Topping>()
        //like an JS object; type string is the property name and topping is the value, AvailToppings
        //are the available toppings
        {
            {"pep", new Topping("Pepperoni", .50m)}
            //constuctor with two arugments comes from Toppings model
            //.50m the 'm' is of type decimal
        };
        public static List<Pizza> Pizzas = new List<Pizza>()
        {
            new Pizza() {
                Name = "Hawaiian",
            }
        };

    }
}
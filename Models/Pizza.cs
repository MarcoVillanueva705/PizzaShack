using System.Collections.Generic;
using System.Linq;

namespace pizza_shack.Models
{
    public enum PizzaSizes
    {
        Personal = 1,
        Medium,
        Large,
        Family
    }
    public class Pizza
    {
        private decimal _BasePrice = 6;

        public string Name { get; set; }
        public List<Topping> Toppings { get; set; } = new List<Topping>();

        public PizzaSizes Size { get; set; }

        public decimal Price 
        { 
            get
            {
                return _BasePrice + (decimal)Size + Toppings.Sum(topping => topping.Price);//Size is an enum, have to make dcimal to add
                        //for every topping on this lists, run this Toppings.Sum method;
                        //iterate through individual toppings and only return the price, the sum method
                        //adds it to a running total
                        //once it's finished we have the total price for all individual toppings and is added
                        //to the size of the pizza plus the base price
                        //this still returns null
            }
        }
    }
}
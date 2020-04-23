using System.Collections.Generic;

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
        public List<Topping> Toppings { get; set; }

        public PizzaSizes Size { get; set; }

        public decimal Price 
        { 
            get
            {
                return _BasePrice + (decimal) Size;//Size is an enum, have to make dcimal to add
            }
        }
    }
}
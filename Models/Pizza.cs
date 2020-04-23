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
        public List<Topping> Toppings { get; set; }

        public PizzaSizes Size { get; set; }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace pizza_shack.Models
{
    public class OrderRequest
    {
        public string Name { get; set; }

        public List<string> ToppingNames { get; set; }

       public PizzaSizes Size { get; set; }

        Pizza Pizza { get; }

      
    public Pizza FulfillRequest()
    {
        ToppingNames.ForEach(topping =>
        {
            System.Console.WriteLine(topping);
        });
    }

    }
    public class Order
    {
        public List<Pizza> Pizzas { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return Pizzas.Sum(pizza=> pizza.Price);
            }
        }
    }

}
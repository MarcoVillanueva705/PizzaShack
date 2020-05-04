using System.Collections.Generic;
using System.Linq;
using pizza_shack.Mock;

namespace pizza_shack.Models
{
    public class OrderRequest
    {
        public string Name { get; set; }

        public List<string> ToppingNames { get; set; }

       public PizzaSizes Size { get; set; }

      
    public Pizza FulfillRequest()
    {
        Pizza pizza = new Pizza();
        pizza.Name = Name;
        ToppingNames.ForEach(t =>
        {
           
           if( fakeDb.AvailToppings.TryGetValue(t, out Topping topping))
            {
                pizza.Toppings.Add(topping);
            }
        });
        return pizza;
    }

    }
    public class Order
    {
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

        public decimal TotalPrice
        {
            get
            {
                return Pizzas.Sum(pizza=> pizza.Price);
            }
        }
    }

}
using System.Collections.Generic;
using System.Linq;

namespace pizza_shack.Models
{
    public class OrderRequest
    {
        List<Pizza> Pizzas { get; set; }

        public OrderRequest()
        {

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
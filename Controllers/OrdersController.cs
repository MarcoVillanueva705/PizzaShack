using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using pizza_shack.Mock;
using pizza_shack.Models;

namespace pizza_shack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            return fakeDb.Orders;
        }

        [HttpPost]
        public ActionResult<Order> Create([FromBody] List<OrderRequest> request)
        {
            Order o = new Order();
            request.ForEach(r => o.Pizzas.Add(r.FulfillRequest()));
            return o;
        }
    }
}
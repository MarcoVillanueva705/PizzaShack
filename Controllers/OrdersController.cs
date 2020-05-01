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
        public ActionResult<Order> Create([FromBody] Order o)
        {
            return o;
        }
    }
}
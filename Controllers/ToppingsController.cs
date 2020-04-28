using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using pizza_shack.Models;

namespace pizza_shack.Controllers
{
    [Route("api/toppings")]
    [ApiController]
    public class ToppingsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Topping>> Get()
        {
            
        }
    }
}
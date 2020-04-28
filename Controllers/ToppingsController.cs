using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using pizza_shack.Mock;
using pizza_shack.Models;

namespace pizza_shack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToppingsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Dictionary<string, Topping>> Get()
        {
            return fakeDb.AvailToppings;
        }
    }
}
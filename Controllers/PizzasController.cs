using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using pizza_shack.Mock;
using pizza_shack.Models;

namespace pizza_shack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Pizza>> GetAction()
        {
            return fakeDb.Pizzas;
        }
    }
}
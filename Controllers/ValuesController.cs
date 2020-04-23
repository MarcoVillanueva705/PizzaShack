using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace pizza_shack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
       public List<string> MyValues = new List<string>() {"value1", "value2", "value3"};

    // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return MyValues;
        }

    //GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if(id < MyValues.Count)
            {
                return MyValues[id];
            }
            return BadRequest("Index out of range");
        }

        //POST api/values
        [HttpPost]
        public ActionResult<IEnumerable<string>> Post([FromBody] string value)
        {
            MyValues.Add(value);
            return MyValues;
        }

    }
}
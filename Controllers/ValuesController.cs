using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pizza_shack.Mock;

namespace pizza_shack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

    // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return fakeDb.MyValues;
        }

    //GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if(id < fakeDb.MyValues.Count)
            {
                return fakeDb.MyValues[id];
            }
            return BadRequest("Index out of range");
        }

        //POST api/values
        [HttpPost]
        public ActionResult<IEnumerable<string>> Post([FromBody] string value)
        {
            fakeDb.MyValues.Add(value);
            return fakeDb.MyValues;
        }

    }
}
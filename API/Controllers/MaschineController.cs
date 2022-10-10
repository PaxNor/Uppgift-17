using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/maschine")]
    [ApiController]
    public class MaschineController : ControllerBase
    {
        // GET: api/<MaschineController>
        [HttpGet]
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MaschineController>/5
        [HttpGet("{id}")]
        public string Get(int id) {
            return "value";
        }

        // POST api/<MaschineController>
        [HttpPost]
        public void Post([FromBody] string value) {
        }

        // PUT api/<MaschineController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/<MaschineController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}

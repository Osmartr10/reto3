using EnrolamientoAPI.Models;
using EnrolamientoAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EnrolamientoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrolamientoController : ControllerBase
    {
        private readonly IEnrolamientoService enrolamientoService;
        public EnrolamientoController(IEnrolamientoService enrolamientoContexto)
        {
            this.enrolamientoService = enrolamientoContexto;
        }


        // GET: api/<EnrolamientoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EnrolamientoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EnrolamientoController>
        [HttpPost]
        public IActionResult Post(Enrolamiento enrol)
        {
            return Ok(enrolamientoService.Create(enrol));
        }

        // PUT api/<EnrolamientoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EnrolamientoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
           return Ok(enrolamientoService.Delete(id));
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IQuestionRepository rep;
        public StateController(IQuestionRepository rep)
        {
            this.rep = rep;
        }
        // GET: api/<StateController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(rep.GetStates());
        }

        // GET api/<StateController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(rep.GetState(id));
        }

        // POST api/<StateController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StateController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StateController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

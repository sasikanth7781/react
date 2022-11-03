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
    public class DietController : ControllerBase
    {
        private readonly IQuestionRepository rep;
        public DietController(IQuestionRepository rep)
        {
            this.rep = rep;
        }
        // GET api/<DietController>/5
        [HttpGet("{id}")]
        public IActionResult  Get(int id)
        {
            return Ok(rep.GetDiets(id));
        }
      
        // POST api/<DietController>
        [HttpPost]
        public IActionResult  Post(Diet diet)
        {
            var obj = rep.AddDiet(diet);
            return CreatedAtAction("Get", new { id = obj.Id }, obj);
        }

        // PUT api/<DietController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DietController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

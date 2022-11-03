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
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionRepository rep;
        public QuestionController(IQuestionRepository rep)
        {
            this.rep = rep;
        }
        // GET: api/<QuestionController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(rep.GetPatients());
        }
        [HttpGet("{id}")]
        public IActionResult  Get(int id)
        {
            return Ok(rep.getPatient(id));
        }

        // POST api/<QuestionController>
        [HttpPost]
        public IActionResult  Post(Patient p)
        {
            var obj=rep.add_patient(p);
            return CreatedAtAction("Get", new { id = obj.Id}, obj);
        }

        // PUT api/<QuestionController>/5
        [HttpPut("{id}")]
        public IActionResult  Put(int id,Patient p)
        {
            return Ok(rep.update_patient(id, p));
        }

        // DELETE api/<QuestionController>/5
        [HttpDelete("{id}")]
        public IActionResult  Delete(int id)
        {
            return Ok(rep.delete_patient(id));
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNETUdemy.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;

        private IPersonService _personService;
        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_personService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personService.FindByID(id);

            if (person == null) return NotFound();

            return Ok(person);
        }


        [HttpPost("{id}")]
        public IActionResult Post([FromBody] PersonController person)
        {
            if (person == null) return BadRequest();

            return Ok(_personService);
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] PersonController person)
        {
            if (person == null) return BadRequest();

            return Ok(_personService);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
           _personService.Delete(id);
            return NoContent();
        }

    }
}

using Application_Layer.Students.Commands.CreateStudentCommand;
using Application_Layer.Students.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI_CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {       

        private readonly ISender _sender;
        public StudentController(ISender sender) {
            _sender = sender;       
        }

        // GET: api/<StudentController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _sender.Send(new GetAllStudentsQuery());

            return result.IsSuccess ? Ok(result.Value): BadRequest(result.Error);

        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] CreateStudentCommand command)
        {
           // var command=new CreateStudentCommand()
           var result=_sender.Send(command);

        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

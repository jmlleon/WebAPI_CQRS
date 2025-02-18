using Application_Layer.Mapper;
using Application_Layer.Students.Commands.Create;
using Application_Layer.Students.Commands.Delete;
using Application_Layer.Students.Commands.Update;
using Application_Layer.Students.Queries.GetAll;
using Application_Layer.Students.Queries.GetStudentById;
using Domain_Layer.DTO;
using Domain_Layer.Errors;
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
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<CustomResult<StudentResponse>>> Get(Guid id)
        {
            var result = await _sender.Send(new GetStudentByIdQuery(id));

            if(result.IsFailure) {            
                return result.Error.Equals(StudentErrors.NotFoundStudent) ? NotFound(result.Error) : BadRequest(result.Error);
            }
            return Ok(result.Value);
        }

        // POST api/<StudentController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateStudentCommand command)
        {
            var result = await _sender.Send(command);

            if (result.IsFailure) {
                return BadRequest(result.Error);
            }           

            return CreatedAtAction("Get", new {id=result.Value}, command);

        }

        // PUT api/<StudentController>/5
        [HttpPut("{id:Guid}")]
        public async Task<ActionResult> Put(Guid id, [FromBody] UpdateStudentDTO updateDTO)
        {

            var command = new UpdateStudentCommand(updateDTO.Id, updateDTO.Name, updateDTO.LastName, updateDTO.Age, id);
            
            var result = await _sender.Send(command);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }

            return Ok(result.Value);

        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var result = await _sender.Send(new DeleteStudentCommand(id));

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok(result.Value);
        }
    }
}

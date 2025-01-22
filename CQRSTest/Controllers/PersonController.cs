using CQRSTest.DataAccessLayer.Commands;
using CQRSTest.DataAccessLayer.Models;
using CQRSTest.DataAccessLayer.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mediator.Send(new GetPersonDetailQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Post(Person person)
        {
            return Ok(await _mediator.Send(new AddPersonCommand(person)));
        }
    }
}

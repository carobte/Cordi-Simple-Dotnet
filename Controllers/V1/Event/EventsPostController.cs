using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleDotnet.DTO.Event;
using CordiSimpleDotnet.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CordiSimpleDotnet.Controllers.V1.Event
{
    [ApiController]
    [Route("api/v1/events")]
    [Tags("events")]
    public class EventsPostController : EventsController
    {
        public EventsPostController(IEventRepository repository) : base(repository) { }

        [HttpPost]
        [SwaggerOperation(
            Summary = "Create event",
            Description = "Register event in database"
        )]
        [SwaggerResponse(204, "created: event registered successfully")]
        [SwaggerResponse(400, "bad request")]
        public async Task<IActionResult> CreateEvent(EventRequest newEvent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _repository.Create(newEvent);
            return NoContent();
        }
    }
}
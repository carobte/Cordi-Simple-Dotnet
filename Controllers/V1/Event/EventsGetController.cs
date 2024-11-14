using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleDotnet.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CordiSimpleDotnet.Controllers.V1.Event
{
    [ApiController]
    [Route("api/v1/events")]
    [Tags("events")]
    public class EventsGetController : EventsController
    {
        public EventsGetController(IEventRepository repository) : base(repository)
        {
        }

        [HttpGet]
        [SwaggerOperation(
          Summary = "Get events",
          Description = "Returns all the events in database")]
        [SwaggerResponse(200, "Ok: Returns all the events in database")]
        [SwaggerResponse(204, "No Content: There are not events in the database")]

        public async Task<IActionResult> Get()
        {
            var events = await _repository.Get();

            if (events == null || !events.Any())
            {
                return NoContent();
            }

            return Ok(events);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(
          Summary = "Get event by id",
          Description = "Returns an specific event in database")]
        [SwaggerResponse(200, "Ok: Returns an specific event in database")]
        [SwaggerResponse(204, "No Content: There are not events in the database with the given id")]

        public async Task<IActionResult> GetById(int id)
        {
            var eventFound = await _repository.GetById(id);

            if (eventFound == null)
            {
                return NoContent();
            }

            return Ok(eventFound);
        }

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleDotnet.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CordiSimpleDotnet.Controllers.V1.Event
{
    [ApiController]
    [Route("api/v1/events")]
    public class EventsController : ControllerBase
    {
        protected readonly IEventRepository _repository;

        public EventsController(IEventRepository repository)
        {
            _repository = repository;
        }
    }
}
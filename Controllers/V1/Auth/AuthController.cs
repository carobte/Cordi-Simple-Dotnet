using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleDotnet.DTO.Auth;
using CordiSimpleDotnet.Models;
using CordiSimpleDotnet.Repositories;
using CordiSimpleDotnet.Utilities;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;


namespace CordiSimpleDotnet.Controllers.V1.Auth
{
    [ApiController]
    [Route("api/v1/users")]
    [Tags("users")]
    public class AuthController : ControllerBase
    {
        protected readonly IUserRepository _repository;
        protected readonly PasswordHasher _passwordHasher;

        public AuthController(IUserRepository repository, PasswordHasher passwordHasher)
        {
            _repository = repository;
            _passwordHasher = passwordHasher;
        }

        [HttpPost("register")]
        [SwaggerOperation(
            Summary = "Create user",
            Description = "Register user in database"
        )]
        [SwaggerResponse(200, "Created: User registered successfully")]
        [SwaggerResponse(400, "Bad request")]

        public async Task<IActionResult> Post(RegisterRequest newUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _repository.Register(newUser);
            return Ok(newUser.Name + " was registered successfully" ); 
        }
    }
}
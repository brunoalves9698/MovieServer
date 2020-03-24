using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieService.Domain.Commands.Core;
using MovieService.Domain.Commands.Inputs.Account;
using MovieService.Domain.Handlers;

namespace MovieService.Api.Controllers.v1
{
    [Route("v1/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        public GenericCommandResult Login(
            [FromBody]AccountLoginCommand command,
            [FromServices]AccountHandler handler)
        {
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}
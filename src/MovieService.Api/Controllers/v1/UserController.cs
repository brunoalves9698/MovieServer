using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieService.Domain.Commands.Core;
using MovieService.Domain.Commands.Inputs.User;
using MovieService.Domain.Entities;
using MovieService.Domain.Handlers;
using MovieService.Domain.Repositories;
using System;

namespace MovieService.Api.Controllers.v1
{
    [Route("v1/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [AllowAnonymous]
        [Route("")]
        public GenericCommandResult Post(
            [FromBody]RegisterUserCommand command,
            [FromServices]UserHandler handler)
        {
            return (GenericCommandResult)handler.Handle(command);
        }

        [HttpPut]
        //[Authorize(Roles = "USER")]
        [Route("")]
        public GenericCommandResult Put(
            [FromBody]UpdateUserCommand command,
            [FromServices]UserHandler handler)
        {
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using MovieService.Domain.Entities;
using MovieService.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace MovieService.Api.Controllers.v1
{
    [Route("v1/movies")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        //[Authorize(Roles = "USER")]
        public IEnumerable<Movie> Get([FromServices] IMovieRepository repository)
        {
            return repository.GetAll();
        }

        [Route("genre/{genre:int}")]
        [HttpGet]
        //[Authorize(Roles = "USER")]
        public IEnumerable<Movie> GetByGenre(int genre, [FromServices] IMovieRepository repository)
        {
            return repository.GetByGenre(genre);
        }

        [Route("releasedate/{releasedate}")]
        [HttpGet]
        //[Authorize(Roles = "USER")]
        public IEnumerable<Movie> GetByRelease(string releasedate, [FromServices] IMovieRepository repository)
        {
            return repository.GetByRelease(DateTime.Parse(releasedate));
        }

        [Route("genre/{genre:int}/releasedate/{releasedate}")]
        [HttpGet]
        //[Authorize(Roles = "USER")]
        public IEnumerable<Movie> GetByGenreAndReleaseDate(int genre, string releasedate, [FromServices] IMovieRepository repository)
        {
            return repository.GetByGenreAndReleaseDate(genre, DateTime.Parse(releasedate));
        }
    }
}
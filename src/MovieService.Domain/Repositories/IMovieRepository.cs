using MovieService.Domain.Entities;
using System;
using System.Collections.Generic;

namespace MovieService.Domain.Repositories
{
    public interface IMovieRepository
    {
        Movie GetById(Guid id);
        IEnumerable<Movie> GetAll();
        IEnumerable<Movie> GetByGenre(int genre);
        IEnumerable<Movie> GetByRelease(DateTime releaseDate);
        IEnumerable<Movie> GetByGenreAndReleaseDate(int genre, DateTime releaseDate);
    }
}

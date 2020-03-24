using MovieService.Domain.Entities;
using MovieService.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace MovieService.Tests.Fakes.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public Movie GetById(Guid id)
        {
            return null;
        }

        public IEnumerable<Movie> GetByGenre(int genre)
        {
            return new List<Movie>();
        }

        public IEnumerable<Movie> GetAll()
        {
            return new List<Movie>();
        }

        public IEnumerable<Movie> GetByRelease(DateTime releaseDate)
        {
            return new List<Movie>();
        }

        public IEnumerable<Movie> GetByGenreAndReleaseDate(int genre, DateTime releaseDate)
        {
            return new List<Movie>();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using MovieService.Domain.Entities;
using MovieService.Domain.Queries;
using MovieService.Domain.Repositories;
using MovieService.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieService.Infra.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _context;

        public MovieRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie> GetAll()
        {
            return _context.Movie;
        }

        public IEnumerable<Movie> GetByGenre(int genre)
        {
            return _context.Movie
               .AsNoTracking()
               .Where(MovieQueries.GetByGenre(genre))
               .OrderBy(x => x.Name);
        }

        public IEnumerable<Movie> GetByGenreAndReleaseDate(int genre, DateTime releaseDate)
        {
            return _context.Movie
               .AsNoTracking()
               .Where(MovieQueries.GetByGenre(genre))
               .Where(MovieQueries.GeteByReleaseDate(releaseDate))
               .OrderBy(x => x.Name);
        }

        public Movie GetById(Guid id)
        {
            return _context.Movie.SingleOrDefault(MovieQueries.GetById(id));
        }

        public IEnumerable<Movie> GetByRelease(DateTime releaseDate)
        {
            return _context.Movie
               .AsNoTracking()
               .Where(MovieQueries.GeteByReleaseDate(releaseDate))
               .OrderBy(x => x.Name);
        }
    }
}

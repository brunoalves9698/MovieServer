using MovieService.Domain.Entities;
using MovieService.Domain.Enums;
using System;
using System.Linq.Expressions;

namespace MovieService.Domain.Queries
{
    public class MovieQueries
    {
        public static Expression<Func<Movie, bool>> GetById(Guid id)
        {
            return x => x.Id == id;
        }

        public static Expression<Func<Movie, bool>> GetByGenre(int genre)
        {
            return x => x.Genre == (EMovieGenre)Enum.GetValues(typeof(EMovieGenre)).GetValue(genre - 1);
        }

        public static Expression<Func<Movie, bool>> GeteByReleaseDate(DateTime releaseDate)
        {
            return x => x.ReleaseDate == releaseDate.Date;
        }
    }
}

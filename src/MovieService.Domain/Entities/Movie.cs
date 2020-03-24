using MovieService.Domain.Entities.Core;
using MovieService.Domain.Enums;
using System;

namespace MovieService.Domain.Entities
{
    public class Movie : Entity
    {
        protected Movie() { }

        public Movie(
            string name, 
            TimeSpan duration, 
            EMovieRating rating, 
            EMovieGenre genre,
            EMovieNationality nationality, 
            string distributor, 
            string director, 
            string cast, 
            string sinopse,
            string trailer,
            string portraitImage, 
            string landscapeImage,
            DateTime releaseDate)
        {
            Name = name;
            Duration = duration;
            Rating = rating;
            Genre = genre;
            Nationality = nationality;
            Distributor = distributor;
            Director = director;
            Cast = cast;
            Sinopse = sinopse;
            Trailer = trailer;
            PortraitImage = portraitImage;
            LandscapeImage = landscapeImage;
            ReleaseDate = releaseDate;
        }

        public string Name { get; private set; }
        public TimeSpan Duration { get; private set; }
        public EMovieRating Rating { get; private set; }
        public EMovieGenre Genre { get; private set; }
        public EMovieNationality Nationality { get; private set; }
        public string Distributor { get; private set; }
        public string Director { get; private set; }
        public string Cast { get; private set; }
        public string Sinopse { get; private set; }
        public string Trailer { get; private set; }
        public string PortraitImage { get; private set; }
        public string LandscapeImage { get; private set; }
        public DateTime ReleaseDate { get; private set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

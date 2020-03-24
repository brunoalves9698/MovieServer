using System.ComponentModel;

namespace MovieService.Domain.Enums
{
    public enum EMovieGenre
    {
        [Description("Ação")]
        Action = 1,

        [Description("Aventura")]
        Adventure = 2,

        [Description("Cinema de arte")]
        ArtCinema = 3,

        [Description("Chanchada")]
        Chanchada = 4,

        [Description("Cinema Catástrofe")]
        CinemaCatastrophe = 5,

        [Description("Comédia")]
        Comedy = 6,

        [Description("Comédia Romantica")]
        RomanticComedy = 7,

        [Description("Comédia Dramática")]
        DramaticComedy = 8,

        [Description("Comédia de Ação")]
        ActionComedy = 9,

        [Description("Dança")]
        Dance = 10,

        [Description("Documentário")]
        Documentary = 11,

        [Description("Docuficção")]
        Documentation = 12,

        [Description("Drama")]
        Drama = 13,

        [Description("Espionagem")]
        Espionage = 14,

        [Description("Faroeste")]
        Western = 15,

        [Description("Fantasia Científica")]
        ScienceFantasy = 16,

        [Description("Ficção Científica")]
        ScienceFiction = 17,

        [Description("Guerra")]
        War = 18,

        [Description("Musical")]
        Musical = 19,

        [Description("Policial")]
        Cop = 20,

        [Description("Romance")]
        Romance = 21,

        [Description("Seriado")]
        Sitcom = 22,

        [Description("Suspense")]
        Thriller = 23,

        [Description("Terror")]
        Horror = 24
    }
}

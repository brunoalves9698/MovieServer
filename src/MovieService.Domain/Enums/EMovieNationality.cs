using System.ComponentModel;

namespace MovieService.Domain.Enums
{
    public enum EMovieNationality
    {
        [Description("Nacional")]
        National = 1,

        [Description("Estrangeiro")]
        Foreign = 2
    }
}

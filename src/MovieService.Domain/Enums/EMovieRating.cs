using System.ComponentModel;

namespace MovieService.Domain.Enums
{
    public enum EMovieRating
    {
        [Description("Livre")]
        Free = 1,

        [Description("Dez Anos")]
        TenYears = 2,

        [Description("Doze Anos")]
        TwelveYears = 3,

        [Description("Catorze Anos")]
        FourteenYears = 4,

        [Description("Dezesseis Anos")]
        SixteenYears = 5,

        [Description("Dezoito Anos")]
        EighteenYears = 6,
    }
}

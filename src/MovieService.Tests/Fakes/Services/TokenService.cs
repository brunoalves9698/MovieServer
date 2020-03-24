using MovieService.Domain.Entities;
using MovieService.Domain.Services;

namespace MovieService.Tests.Fakes.Services
{
    public class TokenService : ITokenService
    {
        public string GenerateToken(Account account)
        {
            return "";
        }
    }
}

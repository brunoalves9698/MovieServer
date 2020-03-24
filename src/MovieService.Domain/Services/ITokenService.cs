using MovieService.Domain.Entities;

namespace MovieService.Domain.Services
{
    public interface ITokenService
    {
        string GenerateToken(Account account);
    }
}

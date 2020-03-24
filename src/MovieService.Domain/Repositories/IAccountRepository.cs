using MovieService.Domain.Entities;
using System;

namespace MovieService.Domain.Repositories
{
    public interface IAccountRepository
    {
        void Save(Account account);
        void ChangePassword(Account account);
        Account GetByUserName(string userName);
        Account GetById(Guid userId);
    }
}

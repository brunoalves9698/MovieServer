using MovieService.Domain.Entities;
using MovieService.Domain.Repositories;
using MovieService.Domain.ValueObjects;
using System;

namespace MovieService.Tests.Fakes.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public void ChangePassword(Account account)
        {

        }

        public Account GetById(Guid userId)
        {
            return new Account(userId, new Email("felizberto@teste.com.br"), "password", "USER");
        }

        public Account GetByUserName(string userName)
        {
            if (userName == "felizberto@teste.com.br")
                return new Account(Guid.NewGuid(), new Email("felizberto@teste.com.br"), "password", "USER");

            return null;
        }

        public void Save(Account account)
        {

        }
    }
}

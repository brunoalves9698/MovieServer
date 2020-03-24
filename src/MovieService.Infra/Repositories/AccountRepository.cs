using Microsoft.EntityFrameworkCore;
using MovieService.Domain.Entities;
using MovieService.Domain.Queries;
using MovieService.Domain.Repositories;
using MovieService.Infra.Contexts;
using System;
using System.Linq;

namespace MovieService.Infra.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataContext _context;

        public AccountRepository(DataContext context)
        {
            _context = context;
        }

        public void ChangePassword(Account account)
        {
            _context.Entry(account).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Account GetById(Guid id)
        {
            return _context.Account.SingleOrDefault(AccountQueries.GetById(id));
        }

        public Account GetByUserName(string userName)
        {
            return _context.Account.SingleOrDefault(AccountQueries.GetByUserName(userName));
        }

        public void Save(Account account)
        {
            _context.Account.Add(account);
            _context.SaveChanges();
        }
    }
}

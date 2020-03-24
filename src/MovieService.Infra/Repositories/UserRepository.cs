using Microsoft.EntityFrameworkCore;
using MovieService.Domain.Entities;
using MovieService.Domain.Queries;
using MovieService.Domain.Repositories;
using MovieService.Infra.Contexts;
using System;
using System.Linq;

namespace MovieService.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public bool DocumentExists(string document)
        {
            return _context.User.Any(UserQueries.GetByDocument(document));
        }

        public bool EmailExists(string email)
        {
            return _context.User.Any(UserQueries.GetByEmail(email));
        }

        public User GetById(Guid id)
        {
            return _context.User.SingleOrDefault(UserQueries.GetById(id));
        }

        public void Save(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}

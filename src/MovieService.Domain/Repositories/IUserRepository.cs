using MovieService.Domain.Entities;
using System;

namespace MovieService.Domain.Repositories
{
    public interface IUserRepository
    {
        void Save(User user);
        void Update(User user);
        User GetById(Guid id);
        bool EmailExists(string email);
        bool DocumentExists(string document);
    }
}

using MovieService.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace MovieService.Domain.Queries
{
    public class AccountQueries
    {
        public static Expression<Func<Account, bool>> GetById(Guid id)
        {
            return x => x.Id == id;
        }

        public static Expression<Func<Account, bool>> GetByUserName(string userName)
        {
            return x => x.UserName.EmailProperty == userName;
        }
    }
}

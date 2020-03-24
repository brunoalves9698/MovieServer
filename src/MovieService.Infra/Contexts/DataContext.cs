using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using MovieService.Domain.Entities;
using MovieService.Domain.Shared;
using MovieService.Infra.Contexts.Maps;

namespace MovieService.Infra.Contexts
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Settings.ConnectionString);
        }

        public DbSet<User> User { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Movie> Movie { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Ignore<Notification>();

            builder.ApplyConfiguration(new AccountMap());
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new MovieMap());
        }
    }
}

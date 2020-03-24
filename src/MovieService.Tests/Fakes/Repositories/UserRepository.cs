using MovieService.Domain.Entities;
using MovieService.Domain.Enums;
using MovieService.Domain.Repositories;
using MovieService.Domain.ValueObjects;
using System;

namespace MovieService.Tests.Fakes.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User GetById(Guid id)
        {
            if (id == Guid.Parse("d6898b4a-ec9a-4e9e-bf4c-7cdf0a0e82dd"))
            {
                var name = new Name("Felizberto", "Alves");
                var document = new Document("26206522008");
                var email = new Email("felizberto@teste.com.br");
                var phone = new Phone("99999999999");
                var address = new Address("Rua a", "N 1", "Bairro a", "Cidade a", "Estado a", "Pais a", "00000000");

                return new User(
                    name,
                    document,
                    EGender.Male,
                    DateTime.Now.AddYears(-18).Date,
                    email,
                    phone,
                    address);
            }

            return null;
        }

        public void Save(User user)
        {
            
        }

        public void Update(User user)
        {
            
        }

        public bool DocumentExists(string document)
        {
            return document == "00128768010" ? true : false;
        }

        public bool EmailExists(string email)
        {
            return email == "fulano@teste.com.br" ? true : false;
        }
    }
}

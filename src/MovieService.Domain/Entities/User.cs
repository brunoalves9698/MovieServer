using MovieService.Domain.Entities.Core;
using MovieService.Domain.Enums;
using MovieService.Domain.ValueObjects;
using System;

namespace MovieService.Domain.Entities
{
    public class User : Entity
    {
        protected User() { }

        public User(
            Name name,
            Document document,
            EGender gender,
            DateTime birthDate,
            Email email,
            Phone phone,
            Address address)
        {
            Name = name;
            Document = document;
            Gender = gender;
            BirthDate = birthDate;
            Email = email;
            Phone = phone;
            Address = address;
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public EGender Gender { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Email Email { get; private set; }
        public Phone Phone { get; private set; }
        public Address Address { get; private set; }

        public override string ToString()
        {
            return Name.ToString();
        }

        public void Update(Phone phone, Address address)
        {
            Phone = phone;
            Address = address;
        }
    }
}

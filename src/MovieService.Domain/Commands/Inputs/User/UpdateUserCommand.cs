using Flunt.Notifications;
using Flunt.Validations;
using MovieService.Domain.Commands.Core;
using System;

namespace MovieService.Domain.Commands.Inputs.User
{
    public class UpdateUserCommand : Notifiable, ICommand
    {
        public UpdateUserCommand() { }

        public UpdateUserCommand(
            Guid id, 
            string phone, 
            string street, 
            string number, 
            string neighborhood, 
            string city, 
            string state, 
            string country, 
            string zipCode)
        {
            Id = id;
            Phone = phone;
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
        }

        public Guid Id { get; set; }
        public string Phone { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
             .Requires()
             .HasMaxLen(Phone, 11, "Phone", "Telefone inválido.")
             .HasMinLen(Street, 3, "Street", "O campo \"Rua\" deve conter no mínimo 3 caracteres.")
             .HasMaxLen(Street, 50, "Street", "O campo \"Rua\" deve conter no máximo 50 caracteres.")
             .HasMaxLen(Number, 10, "Number", "O campo \"Número\" deve conter no máximo 10 caracteres.")
             .HasMinLen(Neighborhood, 3, "Neighborhood", "O Bairro \"Rua\" deve conter no mínimo 3 caracteres.")
             .HasMaxLen(Neighborhood, 50, "Neighborhood", "O Bairro \"Rua\" deve conter no máximo 50 caracteres.")
             .HasMinLen(City, 3, "City", "O campo \"Cidade\" deve conter no mínimo 3 caracteres.")
             .HasMaxLen(City, 80, "City", "O campo \"Cidade\" deve conter no máximo 80 caracteres.")
             .HasMinLen(State, 3, "State", "O campo \"Estado\" deve conter no mínimo 3 caracteres.")
             .HasMaxLen(State, 50, "State", "O campo \"Estado\" deve conter no máximo 50 caracteres.")
             .HasMinLen(Country, 3, "Country", "O campo \"Pais\" deve conter no mínimo 3 caracteres.")
             .HasMaxLen(Country, 50, "Country", "O campo \"Pais\" deve conter no máximo 50 caracteres.")
             .HasMinLen(ZipCode, 8, "ZipCode", "CEP inválido.")
             .HasMaxLen(ZipCode, 8, "ZipCode", "CEP inválido."));
        }
    }
}

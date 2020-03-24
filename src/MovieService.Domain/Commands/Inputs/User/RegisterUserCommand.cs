using Flunt.Notifications;
using Flunt.Validations;
using MovieService.Domain.Commands.Core;
using MovieService.Domain.Enums;
using System;

namespace MovieService.Domain.Commands.Inputs.User
{
    public class RegisterUserCommand : Notifiable, ICommand
    {
        public RegisterUserCommand() { }

        public RegisterUserCommand(
            string email, 
            string password, 
            string fistName, 
            string lastName, 
            string document, 
            EGender gender, 
            DateTime birthDate, 
            string phone, 
            string street, 
            string number, 
            string neighborhood, 
            string city, 
            string state, 
            string country, 
            string zipCode)
        {
            Email = email;
            Password = password;
            FistName = fistName;
            LastName = lastName;
            Document = document;
            Gender = gender;
            BirthDate = birthDate;
            Phone = phone;
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public EGender Gender { get; set; }
        public DateTime BirthDate { get; set; }
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
                .HasMaxLen(Email, 200, "Email", "O campo \"Email\" deve conter no máximo 200 caracteres.")
                .IsEmail(Email, "Email", "E-mail inválido.")
                .HasMinLen(Password, 6, "Password", "O campo \"Senha\" deve conter no mínimo 6 caracteres.")
                .HasMaxLen(Password, 200, "Password", "O campo \"Senha\" deve conter no mínimo 200 caracteres.")
                .HasMinLen(FistName, 3, "FistName", "O campo \"Primeiro Nome\" deve conter no mínimo 3 caracteres.")
                .HasMaxLen(FistName, 50, "FistName", "O campo \"Primeiro Nome\" deve conter no máximo 50 caracteres.")
                .HasMinLen(LastName, 3, "LastName", "O campo \"Sobrenome\" deve conter no mínimo 3 caracteres.")
                .HasMaxLen(LastName, 50, "LastName", "O campo \"Sobrenome\" deve conter no máximo 50 caracteres.")
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

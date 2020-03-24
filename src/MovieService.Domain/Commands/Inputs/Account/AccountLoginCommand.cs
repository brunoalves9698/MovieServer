using Flunt.Notifications;
using Flunt.Validations;
using MovieService.Domain.Commands.Core;

namespace MovieService.Domain.Commands.Inputs.Account
{
    public class AccountLoginCommand : Notifiable, ICommand
    {
        public AccountLoginCommand() { }

        public AccountLoginCommand(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; set; }
        public string Password { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Username, "Username", "E-mail inválido.")
                .HasMinLen(Password, 6, "Password", "O campo \"Senha\" deve conter no mínimo 6 caracteres.")
                .HasMaxLen(Password, 200, "Password", "O campo \"Senha\" deve conter no mínimo 200 caracteres."));
        }
    }
}

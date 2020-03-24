using Flunt.Validations;
using MovieService.Domain.ValueObjects.Core;

namespace MovieService.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        protected Email() { }

        public Email(string emailProperty)
        {
            EmailProperty = emailProperty;

            AddNotifications(new Contract()
                .Requires()
                .HasMaxLen(EmailProperty, 200, "EmailProperty", "O campo \"Email\" deve conter no máximo 200 caracteres.")
                .IsEmail(EmailProperty, "EmailProperty", "Email inválido."));
        }

        public string EmailProperty { get; private set; }

        public override string ToString()
        {
            return EmailProperty;
        }
    }
}

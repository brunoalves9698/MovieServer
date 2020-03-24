using Flunt.Validations;
using MovieService.Domain.ValueObjects.Core;

namespace MovieService.Domain.ValueObjects
{
    public class Phone : ValueObject
    {
        protected Phone() { }

        public Phone(string phoneProperty)
        {
            PhoneProperty = phoneProperty;

            AddNotifications(new Contract()
                .Requires()
                .HasMaxLen(PhoneProperty, 11, "PhoneProperty", "Telefone inválido."));
        }

        public string PhoneProperty { get; private set; }

        public override string ToString()
        {
            return PhoneProperty;
        }
    }
}

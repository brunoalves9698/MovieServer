using Flunt.Validations;
using MovieService.Domain.ValueObjects.Core;

namespace MovieService.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        protected Name() { }

        public Name(string firstNameProperty, string lastNameProperty)
        {
            FirstNameProperty = firstNameProperty;
            LastNameProperty = lastNameProperty;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstNameProperty, 3, "FirstNameProperty", "O campo \"Primeiro Nome\" deve conter no mínimo 3 caracteres.")
                .HasMaxLen(FirstNameProperty, 50, "FirstNameProperty", "O campo \"Primeiro Nome\" deve conter no máximo 50 caracteres.")
                .HasMinLen(LastNameProperty, 3, "LastNameProperty", "O campo \"Sobrenome\" deve conter no mínimo 3 caracteres.")
                .HasMaxLen(LastNameProperty, 50, "LastNameProperty", "O campo \"Sobrenome\" deve conter no máximo 50 caracteres."));
        }

        public string FirstNameProperty { get; private set; }

        public string LastNameProperty { get; private set; }

        public override string ToString()
        {
            return $"{FirstNameProperty} {LastNameProperty}";
        }
    }
}

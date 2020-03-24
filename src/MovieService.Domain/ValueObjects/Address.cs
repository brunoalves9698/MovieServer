using Flunt.Validations;
using MovieService.Domain.ValueObjects.Core;

namespace MovieService.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        protected Address() { }

        public Address(
            string streetProperty,
            string numberProperty,
            string neighborhoodProperty,
            string cityProperty,
            string stateProperty,
            string countryProperty,
            string zipCodeProperty)
        {
            StreetProperty = streetProperty;
            NumberProperty = numberProperty;
            NeighborhoodProperty = neighborhoodProperty;
            CityProperty = cityProperty;
            StateProperty = stateProperty;
            CountryProperty = countryProperty;
            ZipCodeProperty = zipCodeProperty;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(StreetProperty, 3, "StreetProperty", "O campo \"Rua\" deve conter no mínimo 3 caracteres.")
                .HasMaxLen(StreetProperty, 50, "StreetProperty", "O campo \"Rua\" deve conter no máximo 50 caracteres.")
                .HasMaxLen(NumberProperty, 10, "NumberProperty", "O campo \"Número\" deve conter no máximo 10 caracteres.")
                .HasMinLen(NeighborhoodProperty, 3, "NeighborhoodProperty", "O Bairro \"Rua\" deve conter no mínimo 3 caracteres.")
                .HasMaxLen(NeighborhoodProperty, 50, "NeighborhoodProperty", "O Bairro \"Rua\" deve conter no máximo 50 caracteres.")
                .HasMinLen(CityProperty, 3, "CityProperty", "O campo \"Cidade\" deve conter no mínimo 3 caracteres.")
                .HasMaxLen(CityProperty, 80, "CityProperty", "O campo \"Cidade\" deve conter no máximo 80 caracteres.")
                .HasMinLen(StateProperty, 3, "StateProperty", "O campo \"Estado\" deve conter no mínimo 3 caracteres.")
                .HasMaxLen(StateProperty, 50, "StateProperty", "O campo \"Estado\" deve conter no máximo 50 caracteres.")
                .HasMinLen(CountryProperty, 3, "CountryProperty", "O campo \"Pais\" deve conter no mínimo 3 caracteres.")
                .HasMaxLen(CountryProperty, 50, "CountryProperty", "O campo \"Pais\" deve conter no máximo 50 caracteres.")
                .HasMinLen(ZipCodeProperty, 8, "ZipCodeProperty", "CEP inválido.")
                .HasMaxLen(ZipCodeProperty, 8, "ZipCodeProperty", "CEP inválido."));
        }

        public string StreetProperty { get; private set; }

        public string NumberProperty { get; private set; }

        public string NeighborhoodProperty { get; private set; }

        public string CityProperty { get; private set; }

        public string StateProperty { get; private set; }

        public string CountryProperty { get; private set; }

        public string ZipCodeProperty { get; private set; }

        public override string ToString()
        {
            return $"{StreetProperty}, {NumberProperty}, {NeighborhoodProperty}, {CityProperty}, {StateProperty}, {CountryProperty}, {ZipCodeProperty}";
        }
    }
}

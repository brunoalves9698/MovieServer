using System.ComponentModel;

namespace MovieService.Domain.Enums
{
    public enum EGender
    {
        [Description("Masculino")]
        Male = 1,

        [Description("Feminino")]
        Feminine = 2,

        [Description("Não Informado")]
        Uninformed = 3,
    }
}

using Flunt.Notifications;
using MovieService.Domain.Commands.Core;
using MovieService.Domain.Commands.Inputs.Account;
using MovieService.Domain.Handlers.Core;
using MovieService.Domain.Repositories;
using MovieService.Domain.Services;

namespace MovieService.Domain.Handlers
{
    public class AccountHandler :
        Notifiable,
        IHandler<AccountLoginCommand>
    {
        private readonly IAccountRepository _repository;
        private readonly ITokenService _tokenService;

        public AccountHandler(IAccountRepository repository, ITokenService tokenService)
        {
            _repository = repository;
            _tokenService = tokenService;
        }

        public ICommandResult Handle(AccountLoginCommand command)
        {
            // Fail fast validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Dados inválidos. Verifique o preenchimento dos campos e tente novamente.", command.Notifications);

            // Recupera User
            var account = _repository.GetByUserName(command.Username);

            // Valida UseName
            if (account == null)
                return new GenericCommandResult(false, "Email não cadastrado.", command.Notifications);

            // Valida Password
            if(account.Password != account.EncryptPassword(command.Password))
                return new GenericCommandResult(false, "Senha incorreta.", command.Notifications);

            // Gera Token
            var token = _tokenService.GenerateToken(account);

            // Retorna as Informações
            return new GenericCommandResult(true, "Bem vindo de volta.", new
            {
                user = new
                {
                    account.Id,
                    email = account.UserName.EmailProperty
                },
                token
            });
        }
    }
}

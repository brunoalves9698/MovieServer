using Flunt.Notifications;
using MovieService.Domain.Commands.Core;
using MovieService.Domain.Commands.Inputs.User;
using MovieService.Domain.Entities;
using MovieService.Domain.Handlers.Core;
using MovieService.Domain.Repositories;
using MovieService.Domain.ValueObjects;
using System.Transactions;

namespace MovieService.Domain.Handlers
{
    public class UserHandler :
        Notifiable,
        IHandler<RegisterUserCommand>,
        IHandler<UpdateUserCommand>
    {
        private readonly IUserRepository _userRepository;
        private readonly IAccountRepository _accountRepository;
        public UserHandler(IUserRepository userRepository, IAccountRepository accountRepository)
        {
            _userRepository = userRepository;
            _accountRepository = accountRepository;
        }

        public ICommandResult Handle(RegisterUserCommand command)
        {
            // fail fast validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Dados inválidos. Verifique o preenchimento dos campos e tente novamente.", command.Notifications);

            // verfica se Document já está cadastrado
            if (_userRepository.DocumentExists(command.Document))
                AddNotification("Document", "Este CPF já está em uso.");

            // Verifica se E-mail já está cadastrado
            if (_userRepository.EmailExists(command.Email))
                AddNotification("Email", "Este E-mail já está em uso.");

            // Gera VOs
            var name = new Name(command.FistName, command.LastName);
            var document = new Document(command.Document);
            var email = new Email(command.Email);
            var phone = new Phone(command.Phone);
            var address = new Address(command.Street, command.Number, command.Neighborhood, command.City, command.State, command.Country, command.ZipCode);

            // Gera as Entidades
            var user = new User(name, document, command.Gender, command.BirthDate, email, phone, address);
            var account = new Account(user.Id, email, command.Password, "USER");

            // Agrupa Validações
            AddNotifications(name, document, email, phone, address);

            // Checa Notificações
            if (Invalid)
                return new GenericCommandResult(false, "Dados inválidos. Verifique o preenchimento dos campos e tente novamente.", Notifications);

            // Salva as Informações
            using (var transaction = new TransactionScope())
            {
                _userRepository.Save(user);
                _accountRepository.Save(account);
                transaction.Complete();
            }

            // Retorna as Informações
            return new GenericCommandResult(true, "Cadastro realizado com sucesso.", new
            {
                user.Id,
                Name = name.ToString(),
                Email = email.ToString()
            });
        }

        public ICommandResult Handle(UpdateUserCommand command)
        {
            // fail fast validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Dados inválidos. Verifique o preenchimento dos campos e tente novamente.", command.Notifications);

            // Gera VOs
            var phone = new Phone(command.Phone);
            var address = new Address(command.Street, command.Number, command.Neighborhood, command.City, command.State, command.Country, command.ZipCode);

            // Recupera Entidade (reidratação)
            var user = _userRepository.GetById(command.Id);

            if(user == null)
                return new GenericCommandResult(false, "Dados inválidos. Usuário não encontrado.", null);

            // Altera a Entidade
            user.Update(phone, address);

            // Salva as Informações
            _userRepository.Update(user);

            // Retorna as Informações
            return new GenericCommandResult(true, "Atualização realizada com sucesso.", new
            {
                user.Id,
                Name = user.ToString(),
                Email = user.Email.ToString()
            });
        }
    }
}

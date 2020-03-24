using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieService.Domain.Commands.Core;
using MovieService.Domain.Commands.Inputs.Account;
using MovieService.Domain.Handlers;
using MovieService.Domain.Repositories;
using MovieService.Domain.Services;
using MovieService.Tests.Fakes.Repositories;
using MovieService.Tests.Fakes.Services;

namespace MovieService.Tests.Handlers
{
    [TestClass]
    public class AccountHandlerTests
    {
        private readonly IAccountRepository _repository;
        private readonly ITokenService _tokenService;
        private readonly AccountLoginCommand _command;
        private readonly AccountHandler _accountHandler;

        public AccountHandlerTests()
        {
            _repository = new AccountRepository();
            _tokenService = new TokenService();
            _accountHandler = new AccountHandler(_repository, _tokenService);
            _command = new AccountLoginCommand("felizberto@teste.com.br", "password");
        }

        [TestMethod]
        public void Deve_interromper_a_execucao_quando_o_comando_for_invalido()
        {
            _command.Username = "felizbertoteste.com.br";
            _command.Validate();
            Assert.AreEqual(_command.Invalid, true);
        }

        [TestMethod]
        public void Deve_prosseguir_a_execucao_quando_o_comando_for_valido()
        {
            _command.Validate();
            Assert.AreEqual(_command.Valid, true);
        }

        [TestMethod]
        public void Deve_interromper_a_execucao_quando_o_username_nao_tiver_cadastrado()
        {
            _command.Username = "fulano@teste.com.br";
            var result = (GenericCommandResult)_accountHandler.Handle(_command);
            Assert.AreEqual(result.Message, "Email não cadastrado.");
        }

        [TestMethod]
        public void Deve_interromper_a_execucao_quando_o_password_tiver_incorreto()
        {
            _command.Password = "123456";
            var result = (GenericCommandResult)_accountHandler.Handle(_command);
            Assert.AreEqual(result.Message, "Senha incorreta.");
        }

        [TestMethod]
        public void Deve_autenticar_usuario_quando_nao_houver_notificacoes()
        {
            var result = (GenericCommandResult)_accountHandler.Handle(_command);
            Assert.AreEqual(result.Success, true);
        }
    }
}

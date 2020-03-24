using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieService.Domain.Commands.Core;
using MovieService.Domain.Commands.Inputs.User;
using MovieService.Domain.Enums;
using MovieService.Domain.Handlers;
using MovieService.Domain.Repositories;
using MovieService.Tests.Fakes.Repositories;
using System;

namespace MovieService.Tests.Handlers
{
    [TestClass]
    public class UserCommandTests 
    {
        private readonly IUserRepository _userRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly RegisterUserCommand _registerUserCommand;
        private readonly UpdateUserCommand _updateUserCommand;
        private readonly UserHandler _userHandler;

        public UserCommandTests()
        {
            _userRepository = new UserRepository();
            _accountRepository = new AccountRepository();
            _registerUserCommand = new RegisterUserCommand(
                "felizberto@teste.com.br", 
                "password",
                "Felizberto",
                "Alves",
                "26206522008",
                EGender.Male,
                DateTime.Now.AddYears(-18),
                "99999999999",
                "Rua a",
                "SN",
                "Bairro a",
                "Cidade a",
                "Estado a",
                "Pais a",
                "00000000");
            _updateUserCommand = new UpdateUserCommand(
                Guid.NewGuid(),
                "99999999999",
                "Rua a",
                "N a",
                "Bairro a",
                "Cidade a",
                "Estado a",
                "Pais a",
                "00000000");
            _userHandler = new UserHandler(_userRepository, _accountRepository);
        }

        [TestMethod]
        [TestCategory("RegisterUserCommand")]
        public void Deve_interromper_o_registro_quando_o_comando_for_invalido()
        {
            _registerUserCommand.Email = "felizbertoteste.com.br";
            _registerUserCommand.Validate();
            Assert.AreEqual(_registerUserCommand.Invalid, true);
        }

        [TestMethod]
        [TestCategory("RegisterUserCommand")]
        public void Deve_prosseguir_o_registro_quando_o_comando_for_valido()
        {
            _registerUserCommand.Validate();
            Assert.AreEqual(_registerUserCommand.Valid, true);
        }

        [TestMethod]
        [TestCategory("RegisterUserCommand")]
        public void Deve_interromper_o_registro_quando_o_cpf_ja_estiver_em_uso()
        {
            _registerUserCommand.Document = "00128768010";
            _userHandler.Handle(_registerUserCommand);
            Assert.AreEqual(_userHandler.Invalid, true);
        }

        [TestMethod]
        [TestCategory("RegisterUserCommand")]
        public void Deve_interromper_o_registro_quando_o_email_ja_estiver_em_uso()
        {
            _registerUserCommand.Email = "fulano@teste.com.br";
            _userHandler.Handle(_registerUserCommand);
            Assert.AreEqual(_userHandler.Invalid, true);
        }

        [TestMethod]
        [TestCategory("RegisterUserCommand")]
        public void Deve_interromper_o_registro_quando_houver_alguma_notificacao()
        {
            _registerUserCommand.Document = "00128768010";
            _registerUserCommand.Email = "fulano@teste.com.br";
            _userHandler.Handle(_registerUserCommand);
            Assert.AreEqual(_userHandler.Invalid, true);
        }

        [TestMethod]
        [TestCategory("RegisterUserCommand")]
        public void Deve_registrar_usuario_quando_nao_houver_notificacoes()
        {
            var result = (GenericCommandResult)_userHandler.Handle(_registerUserCommand);
            Assert.AreEqual(result.Success, true);
        }

        [TestMethod]
        [TestCategory("UpdateUserCommand")]
        public void Deve_interromper_a_atualizacao_quando_o_comando_for_invalido()
        {
            _updateUserCommand.State = "";
            _updateUserCommand.Validate();
            Assert.AreEqual(_updateUserCommand.Invalid, true);
        }

        [TestMethod]
        [TestCategory("UpdateUserCommand")]
        public void Deve_prosseguir_a_atualizacao_quando_o_comando_for_valido()
        {
            _updateUserCommand.Validate();
            Assert.AreEqual(_updateUserCommand.Valid, true);
        }

        [TestMethod]
        [TestCategory("UpdateUserCommand")]
        public void Deve_interromper_a_atualizacao_quando_usuario_nao_for_encontrado()
        {
            var result = (GenericCommandResult)_userHandler.Handle(_updateUserCommand);
            Assert.AreEqual(result.Success, false);
        }

        [TestMethod]
        [TestCategory("UpdateUserCommand")]
        public void Deve_atualizar_usuario_quando_nao_houver_errors()
        {
            _updateUserCommand.Id = Guid.Parse("d6898b4a-ec9a-4e9e-bf4c-7cdf0a0e82dd");
            var result = (GenericCommandResult)_userHandler.Handle(_updateUserCommand);
            Assert.AreEqual(result.Success, true);
        }
    }
}

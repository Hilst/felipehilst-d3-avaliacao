using felipehilst_d3_avaliacao.Interfaces.Repositories;
using felipehilst_d3_avaliacao.Interfaces.Services;
using felipehilst_d3_avaliacao.Models;

namespace felipehilst_d3_avaliacao.Services
{
    public class LoginService: ILoginService
    {
        private readonly IUsersRepository _usersRepository;

        public LoginService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public User TryLogin(string? email, string? psw)
        {
            if (email == null) { throw new InvalidEmailException(); }
            if (email == null) { throw new InvalidPswException(); }

            User? userToLog = _usersRepository.GetUserByEmail(email);

            if (userToLog == null) { throw new InvalidLoginException(); }

            if (BCrypt.Net.BCrypt.Verify(psw, userToLog.Senha))
            {
                return userToLog;
            }

            throw new InvalidLoginException();
        }
    }

    [Serializable]
    class InvalidLoginException : Exception
    {
        public InvalidLoginException()
            : base("\nEmail e/ou senha inválidos, tente novamente\n")
        {
        }
    }

    [Serializable]
    class InvalidEmailException : Exception
    {
        public InvalidEmailException()
            : base("\nO email não pode estar vazio\n")
        {
        }
    }

    [Serializable]
    class InvalidPswException : Exception
    {
        public InvalidPswException()
            : base("\nSenha não pode estar vazia\n")
        {
        }
    }
}

using felipehilst_d3_avaliacao.Interfaces.Repositories;
using felipehilst_d3_avaliacao.Interfaces.Services;
using felipehilst_d3_avaliacao.Models;

namespace felipehilst_d3_avaliacao.Services
{
    public class LogonService: ILoginService
    {
        private readonly IUsersRepository _usersRepository;

        public LogonService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public User TryLogon(string email, string psw)
        {
            User? userToLog = _usersRepository.GetUserByEmail(email);

            if (userToLog == null) { throw new InvalidLoginException(); }

            if (BCrypt.Net.BCrypt.Verify(psw, userToLog.Psw))
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
}

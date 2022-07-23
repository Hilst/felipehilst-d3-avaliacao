using felipehilst_d3_avaliacao.Models;
using felipehilst_d3_avaliacao.Repositories;
using felipehilst_d3_avaliacao.Services;

namespace felipehilst_d3_avaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRepository userRepository = new();
            LogonService logonService = new(userRepository);

            try
            {
                User user = logonService.TryLogon("admin@email.com", "admin123");
                Console.WriteLine($"\n{user.UserId}; {user.Nickname}; {user.Email}; {user.Psw}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                User user = logonService.TryLogon("admin@email.com", "abc");
                Console.WriteLine($"\n{user.UserId}; {user.Nickname}; {user.Email}; {user.Psw}\n");
            }
            catch (InvalidLoginException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                User user = logonService.TryLogon("hilst@email.com", "hilst0987");
                Console.WriteLine($"\n{user.UserId}; {user.Nickname}; {user.Email}; {user.Psw}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

using felipehilst_d3_avaliacao.Repositories;

namespace felipehilst_d3_avaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRepository _userRepository = new();

            Console.WriteLine($"\nUser admin: {_userRepository.GetUserByEmail("admin@email.com")?.UserId}\n");
            Console.WriteLine($"\nUser hilst: {_userRepository.GetUserByEmail("hilst@email.com")?.UserId}\n");
        }
    }
}
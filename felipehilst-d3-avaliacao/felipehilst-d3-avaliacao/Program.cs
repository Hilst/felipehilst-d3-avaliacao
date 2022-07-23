using felipehilst_d3_avaliacao.Repositories;
using felipehilst_d3_avaliacao.Models;

namespace felipehilst_d3_avaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var users = new EagerLoadingDbContext())
            {
                var first = users.Users.FirstOrDefault();

                Console.Write($"user: {first?.UserId}; {first?.Nickname}; {first?.Email}; {first?.Psw}");
            }
        }
    }
}
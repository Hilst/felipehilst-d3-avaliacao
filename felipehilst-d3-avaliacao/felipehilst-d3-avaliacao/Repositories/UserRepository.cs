using felipehilst_d3_avaliacao.Interfaces.Repositories;
using felipehilst_d3_avaliacao.Models;

namespace felipehilst_d3_avaliacao.Repositories
{
    public class UserRepository : IUsersRepository
    {
        public User? GetUserByEmail(string email)
        {
            User? userWithEmail;

            using (var dbContext = new EagerLoadingDbContext())
            {
                userWithEmail = dbContext.Users.FirstOrDefault(u => u.Email == email);
            }

            return userWithEmail;
        }
    }
}

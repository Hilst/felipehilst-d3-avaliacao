using felipehilst_d3_avaliacao.Models;

namespace felipehilst_d3_avaliacao.Interfaces.Repositories
{
    public interface IUsersRepository
    {
        User? GetUserByEmail(string email);
    }
}

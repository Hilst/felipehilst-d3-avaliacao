using felipehilst_d3_avaliacao.Models;

namespace felipehilst_d3_avaliacao.Interfaces.Services
{
    public interface ILoginService
    {
        User TryLogin(string? email, string? psw);
    }
}

using felipehilst_d3_avaliacao.Models;

namespace felipehilst_d3_avaliacao.Interfaces.Services
{
    public interface ILoginService
    {
        User TryLogon(string email, string psw);
    }
}

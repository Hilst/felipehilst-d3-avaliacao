using felipehilst_d3_avaliacao.Repositories;
using felipehilst_d3_avaliacao.Interfaces.Services;
using felipehilst_d3_avaliacao.Services;
using felipehilst_d3_avaliacao.Utils;
using felipehilst_d3_avaliacao.Models;

namespace felipehilst_d3_avaliacao.Application
{
    public class Controller
    {
        private readonly ILoginService loginService;
        private readonly Logger logger;
        private AppStates state;
        private User? loggedUser;

        public Controller()
        {
            loginService = new LoginService(new UserRepository());
            logger = new();
            state = AppStates.START;
        }

        public void Run()
        {
            do
            {
                switch (state)
                {
                    case AppStates.START:
                        state = AppStates.AWAIT_ACCESS;
                        break;

                    case AppStates.AWAIT_ACCESS:
                        Console.WriteLine("\nDeseja acessar o sistema:\n");

                        Console.WriteLine("1 - Acessar");
                        Console.WriteLine("2 - Cancelar");
                        Console.WriteLine(" ");

                        string? optionAccess = Console.ReadLine();

                        switch (optionAccess)
                        {
                            case "1":
                                state = AppStates.AWAIT_CREDENTIALS;
                                break;
                            case "2":
                                state = AppStates.DISMISS;
                                break;
                            default:
                                break;
                        }

                        break;

                    case AppStates.AWAIT_CREDENTIALS:
                        Console.WriteLine("\nIniciando seu acesso ao sistema ...\n");

                        Console.WriteLine("\nDigite o seu email de acesso:");
                        var email = Console.ReadLine();

                        Console.WriteLine("\nDigite sua senha de acesso:");
                        var psw = Console.ReadLine();

                        try
                        {
                            loggedUser = loginService.TryLogin(email, psw);
                            state = AppStates.PROCESS_ACCESS;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);

                            if (((InvalidLoginException) ex) != null)
                            {
                                state = AppStates.AWAIT_CREDENTIALS;
                            }
                        }

                        break;

                    case AppStates.PROCESS_ACCESS:
                        Console.WriteLine("\nVocê se logou no sistema com sucesso\n");
                        logger.LogInfo(logged: true, loggedUser!);
                        state = AppStates.AWAIT_ACTION;
                        break;

                    case AppStates.AWAIT_ACTION:
                        Console.WriteLine("\nO que deseja fazer:\n");

                        Console.WriteLine("1 - Deslogar");
                        Console.WriteLine("2 - Encerrar sistema");
                        Console.WriteLine(" ");

                        string? optionAction = Console.ReadLine();

                        switch (optionAction)
                        {
                            case "1":
                                state = AppStates.PROCESS_UNLOG;
                                break;
                            case "2":
                                state = AppStates.DISMISS;
                                break;
                            default:
                                break;
                        }

                        break;

                    case AppStates.PROCESS_UNLOG:
                        Console.WriteLine("\nVocê se deslogou do sistema\n");
                        logger.LogInfo(logged: false, loggedUser!);
                        state = AppStates.AWAIT_ACCESS;
                        break;
                    default:
                        break;
                }

            } while (state != AppStates.DISMISS);
        }
    }
}

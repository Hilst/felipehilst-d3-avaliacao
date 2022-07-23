using felipehilst_d3_avaliacao.Application;

namespace felipehilst_d3_avaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Controller controller = new();

            controller.Run();

            Console.WriteLine("\nEncerrando sistema\n");
        }
    }
}

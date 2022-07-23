using felipehilst_d3_avaliacao.Models;
using Microsoft.Extensions.Configuration;

namespace felipehilst_d3_avaliacao.Utils
{
    public class Logger
    {
        private static string path = "";

        public Logger()
        {
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json", optional: false);

            var configuration = configBuilder.Build();

            path = configuration["LogPath"];

            CreateFolderAndFile(path);
        }

        private static void CreateFolderAndFile(string path)
        {
            string folder = path.Split("/")[0];

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }

        public void LogInfo(bool logged, User user)
        {
            string line = PrepareLoginLine(logged, user);
            AddLine(path, line);
        }

        private static string PrepareLoginLine(bool logged, User user)
        {
            string tipoAcesso = (logged) ? "logou" : "deslogou";
            return $"O usuário {user.Nickname} ({user.UserId}) se {tipoAcesso} ao sistema às {DateTime.Now}";
        }

        private static void AddLine(string path, string newLine)
        {
            using (StreamWriter file = new(path, append: true))
            {
                file.WriteLine(newLine);
            }
        }
    }
}


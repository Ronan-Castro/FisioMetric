namespace FisioMetric.Models.Dao
{
    public class Conn
    {

            private static string servidor;
            private static string bancoDados;
            private static string user;
            private static string senha;

            public static string strConn = $"server={servidor}; User Id={user}; database={bancoDados};password={senha}";

        public static void CarregarConfiguracoesArquivo()
        {
            string nomeArquivo = "FisioMetric.ini";
            string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo);


            if (File.Exists(caminhoArquivo))
            {
                try
                {
                    string[] linhas = File.ReadAllLines(caminhoArquivo);

                    // Atualiza os valores dos atributos com base nas linhas do arquivo
                    servidor = linhas[0].Split('=')[1];
                    bancoDados = linhas[1].Split('=')[1];
                    user = linhas[2].Split('=')[1];
                    senha = linhas[3].Split('=')[1];

                    // Atualiza a string de conexão com os novos valores
                    strConn = $"server={servidor}; User Id={user}; database={bancoDados};password={senha}";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao ler o arquivo de configurações: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("O arquivo de configurações não existe.");
            }
        }
    }
}


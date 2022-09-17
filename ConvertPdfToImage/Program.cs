using ConvertPdfToImage.Converter;
using ConvertPdfToImage.Model;

namespace ConvertPdfToImage
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0 && args[0] != null && args[1] != null && args[2] != null)
            {
                ConvertFile convert = new();
                var response = convert.Convert(new FileModel(args[0], args[1]), args[2]);

                if (!response.Item1) 
                {
                    Console.WriteLine(response.Item2);
                    return;
                }

                Console.WriteLine("Conversão realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foram passados nenhum argumento" +
                    ", favor fornece-los: " +
                    "1 - Caminho do arquivo PDF, " +
                    "2 - Nome dos arquivos convertidos, " +
                    "3 - Extensão que deseja receber os arquivos");
            }
        }
    }
}
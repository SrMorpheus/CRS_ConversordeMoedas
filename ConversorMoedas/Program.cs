using System.Net.Http.Headers;
using System.Net.Http;
using ConversorMoedas;

namespace WebAPIClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {

            Moeda moeda = new Moeda("ZWD", "BRL", 100);

            var teste = await HttpCliente.ProcessRepositories(moeda.QueryRequesicao());

            Console.WriteLine(teste.informacaoTaxa.Taxa);


         


            


        }


   

    }
}

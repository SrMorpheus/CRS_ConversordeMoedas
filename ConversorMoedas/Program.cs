using System.Net.Http.Headers;
using System.Net.Http;
using ConversorMoedas;
using ConversorMoedas.Services;

namespace WebAPIClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {

            Moeda moeda = new Moeda("USD", "BRL", 100);

            Conversor conversor = new Conversor(moeda);

            await conversor.ConvertMoeda();

            conversor.ListagemConversao();

         

         


            


        }


   

    }
}

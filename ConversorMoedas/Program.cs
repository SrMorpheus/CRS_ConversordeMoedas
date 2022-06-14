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


            try
            {


                View view = new View();

                await view.Main();



            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine();


                Console.WriteLine("Errp: Problema na conexão");

            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine();

                Console.WriteLine("Erro: Problema na operação de conversão");


            }catch (Exception ex)
            {
                Console.WriteLine();

                Console.WriteLine("Erro: Problena na conversão devido moedas inválidas");

            }















        }


   

    }
}

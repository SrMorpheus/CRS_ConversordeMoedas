using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Text.Json;
using ConversorMoedas.Repository;

namespace ConversorMoedas
{
    public static class HttpCliente
    {

        private static readonly HttpClient _cliente = new HttpClient();


        public static async Task<Repositorio> ProcessRepositories(string path)
        {

            _cliente.BaseAddress = new Uri("https://api.exchangerate.host/convert");

            _cliente.DefaultRequestHeaders.Clear();

            _cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var streamTask = _cliente.GetStreamAsync(path);

            var repositories = await JsonSerializer.DeserializeAsync<Repositorio>(await streamTask);

            return repositories;


        }


      





    }
}

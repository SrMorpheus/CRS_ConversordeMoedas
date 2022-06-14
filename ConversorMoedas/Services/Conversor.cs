using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;

namespace ConversorMoedas.Services
{
    public class Conversor
    {

        private Moeda _moeda;

        private Repositorio _repositorio;


        public Conversor(Moeda moeda)
        {
            _moeda = moeda;
        }   


        public async Task ConvertMoeda()
        {

         _repositorio = await HttpCliente.ProcessRepositories(_moeda.QueryRequesicao());

        }


        public void ListagemConversao()
        {
            Console.WriteLine();

            Console.WriteLine(_moeda.MoedaOrigem + " " + _moeda.Valor.ToString("N2", new CultureInfo("pt-BR")) + " => " + _moeda.MoedaDestino + " " + _repositorio.Resultado.ToString("N2", new CultureInfo("pt-BR")));

            Console.WriteLine("Taxa: " + _repositorio.informacaoTaxa.Taxa.ToString("N6", new CultureInfo("pt-BR")));

            Console.WriteLine();


        }



    }
}

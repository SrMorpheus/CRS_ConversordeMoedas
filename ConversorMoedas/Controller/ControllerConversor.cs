using ConversorMoedas.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedas
{
    public class ControllerConversor
    {



        public async Task ConverterMoedaAsync(string moedaOrigem, string moedaDestino, string valor)
        {

            var doubleValor = double.Parse(valor);

            Moeda moeda = new Moeda(moedaOrigem, moedaDestino, doubleValor);

            Conversor conversor = new Conversor(moeda);

            await conversor.ConvertMoeda();

            conversor.ListagemConversao();


        }







    }
}

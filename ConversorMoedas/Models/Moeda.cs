using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedas
{
    public class Moeda
    {
        public string MoedaOrigem { get; set; }

        public string MoedaDestino { get; set; }

        public double Valor { get; set; }


        public Moeda(string moedaOrigem, string moedaDestino, double valor)
        {
            this.MoedaOrigem = moedaOrigem;

            this.MoedaDestino = moedaDestino;

            this.Valor = valor;


        }

       
        public string QueryRequesicao()
        {

            return  $"?from={this.MoedaOrigem}&to={this.MoedaDestino}&amount={this.Valor}";


        }




    }
}

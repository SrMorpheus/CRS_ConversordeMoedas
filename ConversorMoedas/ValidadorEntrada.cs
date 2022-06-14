using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConversorMoedas
{
    public class ValidadorEntrada
    {
 

        private List<string> _descricaoErrors { get; set; } = new List<string>();




        public bool ValidarMoedas(string moedaOrigem, string moedaDestino)
        {

            if(moedaOrigem == moedaDestino)
            {

                _descricaoErrors.Add("Error: Moeda de origem não pode ser igual a moeda de destino");
                return false;

            }
            else if(!Formatomoeda(moedaOrigem) || !Formatomoeda(moedaDestino))
            {

                _descricaoErrors.Add("Error: Formato da moeda inválido");
                return false;


            }

            return true;


        }


        public bool ValidarMoeddaValor(string Valor)
        {

            return true;
        }




        private bool Formatomoeda(string moeda)
        {
            return Regex.IsMatch(moeda, "^[A-Z]{3}$");

        }



    }
}

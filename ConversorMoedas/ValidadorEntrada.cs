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


            if(!Regex.IsMatch(Valor, @"^[0-9]+$"))
            {
                _descricaoErrors.Add("Error: Formato do valor inválido");
                return false;


            }
            else
            {
                var valorDouble = double.Parse(Valor);

                if(valorDouble <=0 )
                {
                    _descricaoErrors.Add("Error: valor precisa ser maior que 0");
                    return false;

                }

            }




            return true;
        }




        private bool Formatomoeda(string moeda)
        {
            return Regex.IsMatch(moeda,@"^[A-Z]{3}$");

        }


        public void Error()
        {

           var  erros = _descricaoErrors.Distinct();


            foreach(var listaErros in erros)
            {

                Console.WriteLine(listaErros);


            }



        }




    }
}

using ConversorMoedas.Models;
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
 
        public string DescricaoErros { get; set; }

        public TiposErros Erros { get; set; }
        private List<ValidadorEntrada> _ListErrors { get; set; } = new List<ValidadorEntrada>();




        public bool ValidarMoedas(string moedaOrigem, string moedaDestino)
        {
            ValidadorEntrada validador = new ValidadorEntrada();

            if(moedaOrigem == moedaDestino)
            {
                validador.DescricaoErros = "Erro: Moeda de origem não pode ser igual a moeda de destino";

                validador.Erros = TiposErros.ErroMoeda;

                _ListErrors.Add(validador);



                return false;

            }
            else if(!Formatomoeda(moedaOrigem) || !Formatomoeda(moedaDestino))
            {

                validador.DescricaoErros = "Erro: Formato da moeda inválido";

                validador.Erros = TiposErros.ErroMoeda;

                _ListErrors.Add(validador);


           
                return false;


            }

            return true;


        }


        public bool ValidarMoeddaValor(string Valor)
        {

            ValidadorEntrada validador = new ValidadorEntrada();

            if (!Double.TryParse(Valor, out var R1))
            {

                validador.DescricaoErros = "Erro: Formato do valor inválido";

                validador.Erros = TiposErros.ErroValor;

                _ListErrors.Add(validador);

                return false;


            }
            else
            {
                var valorDouble = double.Parse(Valor);

                if(valorDouble <= 0 )
                {

                    validador.DescricaoErros = "Erro: valor precisa ser maior que 0";

                    validador.Erros = TiposErros.ErroValor;

                    _ListErrors.Add(validador);

                    return false;

                }

            }




            return true;
        }




        private bool Formatomoeda(string moeda)
        {
            return Regex.IsMatch(moeda,@"^[A-Z]{3}$");

        }


        public void Error( TiposErros erros)
        {

            var listaNova = _ListErrors.Where(x => x.Erros == erros).Distinct();

            var listafinal = listaNova.Last();


            Console.WriteLine(listafinal.DescricaoErros);



        }




    }
}

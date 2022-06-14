using ConversorMoedas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedas
{
    public class View
    {

        private ValidadorEntrada _validador = new ValidadorEntrada();

        private ControllerConversor _ControllerConversor = new ControllerConversor();


        private  bool ViewMoeda(out bool reposta, out string moedaOrigemRetorno , out string MoedaDestinoRetorno)
        {
         

            Console.Write("Moeda origem: ");
            var moedaOrigem = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(moedaOrigem))
            {
                reposta = true;

                moedaOrigemRetorno = "";

                MoedaDestinoRetorno = "";

                return false;

            } else
            {
                Console.Write("Moeda destino: ");
                var moedaDestino = Console.ReadLine();

                var boolMoeda = _validador.ValidarMoedas(moedaOrigem, moedaDestino);

                reposta = false;

                moedaOrigemRetorno = moedaOrigem;

                MoedaDestinoRetorno = moedaDestino;

                return boolMoeda;



            }

         

        }


        private bool ViewValor (out string valorRetorno)
        {

            Console.Write("Valor: ");
            var valor = Console.ReadLine();

            var boolValor = _validador.ValidarMoeddaValor(valor);

            valorRetorno = valor;

            return boolValor;


        }


        public async Task Main()
        {

            string moedaOrigem = "";

            string moedaDestino = "";

            string valor = "";

            bool boolValor = true;

            bool reposta = false;

            while(!reposta)
            {

                Console.WriteLine();
                Console.WriteLine("Conversor de Moedas");
                Console.WriteLine();

                var boolMoeda = ViewMoeda(out reposta,out moedaOrigem,out moedaDestino);

                while (!boolMoeda && !reposta) 
                {
                    Console.WriteLine();
                    _validador.Error(TiposErros.ErroMoeda);
                    Console.WriteLine();

                    boolMoeda = ViewMoeda(out reposta, out  moedaOrigem, out moedaDestino);


                }

                if(boolMoeda && !reposta)
                {

                     boolValor = ViewValor(out valor);

                }

                while(!boolValor)
                {
                    Console.WriteLine();
                    _validador.Error(TiposErros.ErroValor);
                    Console.WriteLine();

                    boolValor = ViewValor(out valor);


                }


                if(boolMoeda == true && boolValor == true)
                {


                    await  _ControllerConversor.ConverterMoedaAsync(moedaOrigem, moedaDestino,valor);

                    Console.WriteLine("Pressione qualquer tecla para iniciar uma nova conversão");
                    Console.ReadKey();
                    Console.Clear();

                }

              


            }

           



        }


    }
}

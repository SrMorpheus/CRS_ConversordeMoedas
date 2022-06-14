using ConversorMoedas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConversorMoedas
{
    public class Repositorio
    {
       
        [JsonPropertyName("info")]
        public Informacao informacaoTaxa { get; set; }

        [JsonPropertyName("result")]
        public double Resultado { get; set; }   



    }


 






}

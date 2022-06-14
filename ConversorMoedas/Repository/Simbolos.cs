using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConversorMoedas.Repository
{

 
    public class Simbolos
    {


        [JsonPropertyName("description")]
        public string Descricao { get; set; }

        [JsonPropertyName("code")]
        public string DescricaoNome { get; set; }




    }
}

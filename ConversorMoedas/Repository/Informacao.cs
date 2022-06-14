using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConversorMoedas.Repository
{
    public class Informacao
    {

        [JsonPropertyName("rate")]
        public double Taxa { get; set; }   

        public Informacao( double taxa)
        {

            Taxa = taxa;



        }



    }
}

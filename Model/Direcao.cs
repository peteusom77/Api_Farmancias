using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_farmancias.Model
{
    public class Direcao
    {
        public string? Provincia {get;set;}
        public string? Municipio{get;set;}
        public string? Rua{get;set;}
        public string? Ponto_de_referencia{get;set;}
        public int Codigo_ip{get;set;}


    }
}
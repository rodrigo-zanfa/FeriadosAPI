using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeriadosAPI.Models
{
    public class FeriadoMunicipal : Feriado
    {
        public string Uf { get; set; }
        public string Cidade { get; set; }
    }
}

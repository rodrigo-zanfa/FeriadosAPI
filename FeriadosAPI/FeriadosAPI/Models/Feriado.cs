using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FeriadosAPI.Models
{
    public class Feriado
    {
        [JsonIgnore]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        [NotMapped]
        public string DiaDaSemana { get; set; }
        public string Nome { get; set; }
        public string FixoMovel { get; set; }
    }
}

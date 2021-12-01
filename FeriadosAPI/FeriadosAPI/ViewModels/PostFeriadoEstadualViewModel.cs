using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FeriadosAPI.ViewModels
{
    public class PostFeriadoEstadualViewModel
    {
        [Required]
        public string Uf { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string FixoMovel { get; set; }
    }
}

using FeriadosAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeriadosAPI.Repositories
{
    public static class FeriadoNacionalRepository
    {
        public static IEnumerable<FeriadoNacional> GetAll()
        {
            var result = new List<FeriadoNacional>
            {
                new FeriadoNacional { Id = 1, Data = new DateTime(1900, 1, 1), Nome = "Confraternização Universal", FixoMovel = "F" },
                new FeriadoNacional { Id = 2, Data = new DateTime(1900, 4, 21), Nome = "Tiradentes", FixoMovel = "F" },
                new FeriadoNacional { Id = 3, Data = new DateTime(1900, 5, 1), Nome = "Dia do Trabalhador", FixoMovel = "F" },
                new FeriadoNacional { Id = 4, Data = new DateTime(1900, 9, 7), Nome = "Independência", FixoMovel = "F" },
                new FeriadoNacional { Id = 5, Data = new DateTime(1900, 10, 12), Nome = "Nossa Senhora Aparecida", FixoMovel = "F" },
                new FeriadoNacional { Id = 6, Data = new DateTime(1900, 11, 2), Nome = "Finados", FixoMovel = "F" },
                new FeriadoNacional { Id = 7, Data = new DateTime(1900, 11, 15), Nome = "Proclamação da República", FixoMovel = "F" },
                new FeriadoNacional { Id = 8, Data = new DateTime(1900, 12, 25), Nome = "Natal", FixoMovel = "F" }
            };

            return result;
        }
    }
}

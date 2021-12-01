using FeriadosAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeriadosAPI.Utils
{
    public static class FeriadosMoveis
    {
        public static IEnumerable<FeriadoNacional> GetAll(DateTime data)
        {
            int y = data.Year;
            int ano = y;
            int g = ano % 19;
            int c = ano / 100;
            int h = (c - (c / 4) - (((8 * c) + 13) / 25) + (19 * g) + 15) % 30;
            int i = h - (h / 28) * (1 - (h / 28) * (29 / (h + 1)) * ((21 - g) / 11));
            int j = (ano + (ano / 4) + i + 2 - c + (c / 4)) % 7;
            int l = i - j;
            int m = 3 + ((l + 40) / 44);
            int d = l + 28 - 31 * (m / 4);

            // Domingo de Páscoa - entre 22 de Março e 25 de Abril
            var pascoa = new DateTime(y, m, d);
            while (pascoa.DayOfWeek != DayOfWeek.Sunday)  // procurando até encontrar um Domingo
                pascoa = pascoa.AddDays(1);

            // Sexta-feira Santa - entre 20 de Março e 23 de Abril
            var sextaFeiraSanta = pascoa.AddDays(-2);

            // Terça-feira de Carnaval - entre 3 de Fevereiro e 8 de Março
            var carnaval = pascoa.AddDays(-47);

            // Quinta-feira de Corpus Christi - entre 21 de Maio e 24 de Junho
            var corpusChristi = pascoa.AddDays(60);

            var result = new List<FeriadoNacional>
            {
                new FeriadoNacional { Id = 1, Data = new DateTime(pascoa.Year, pascoa.Month, pascoa.Day), Nome = "Páscoa", FixoMovel = "M" },
                new FeriadoNacional { Id = 2, Data = new DateTime(sextaFeiraSanta.Year, sextaFeiraSanta.Month, sextaFeiraSanta.Day), Nome = "Sexta-feira Santa (Paixão de Cristo)", FixoMovel = "M" },
                new FeriadoNacional { Id = 3, Data = new DateTime(carnaval.Year, carnaval.Month, carnaval.Day), Nome = "Carnaval", FixoMovel = "M" },
                new FeriadoNacional { Id = 4, Data = new DateTime(corpusChristi.Year, corpusChristi.Month, corpusChristi.Day), Nome = "Corpus Christi", FixoMovel = "M" }
            };

            return result;
        }
    }
}

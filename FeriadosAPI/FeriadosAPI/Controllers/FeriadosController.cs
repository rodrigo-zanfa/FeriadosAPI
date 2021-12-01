using FeriadosAPI.Data;
using FeriadosAPI.Models;
using FeriadosAPI.Utils;
using FeriadosAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeriadosAPI.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class FeriadosController : ControllerBase
    {
        //public FeriadosController(DataContext dataContext)
        //{

        //}

        [HttpGet]
        [Route("nacionais")]
        public async Task<IActionResult> GetFeriadosNacionaisAsync([FromServices] DataContext dataContext)
        {
            var result = await dataContext
                .FeriadosNacionais
                .AsNoTracking()
                .ToListAsync();

            result.ForEach(x => x.Data = x.Data.AddYears(DateTime.Today.Year - x.Data.Year));

            var feriadosMoveis = FeriadosMoveis.GetAll(DateTime.Today).ToList();

            result.AddRange(feriadosMoveis);

            var culture = new System.Globalization.CultureInfo("pt-BR");
            //var diaDaSemana = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
            result.ForEach(x => x.DiaDaSemana = culture.DateTimeFormat.GetDayName(x.Data.DayOfWeek));

            var resultOrdenado = result.OrderBy(x => x.Data).ToList();

            return Ok(resultOrdenado);
        }

        [HttpGet]
        [Route("estaduais/{uf}")]
        public async Task<IActionResult> GetFeriadosEstaduaisAsync([FromServices] DataContext dataContext, [FromRoute] string uf)
        {
            var result = await dataContext
                .FeriadosEstaduais
                .AsNoTracking()
                .Where(x => x.Uf == uf)
                .ToListAsync();

            return result == null ? NotFound() : Ok(result);
        }

        [HttpGet]
        [Route("municipais/{uf}/{cidade}")]
        public async Task<IActionResult> GetFeriadosMunicipaisAsync([FromServices] DataContext dataContext, [FromRoute] string uf, [FromRoute] string cidade)
        {
            var result = await dataContext
                .FeriadosMunicipais
                .AsNoTracking()
                .Where(x => x.Uf == uf && x.Cidade == cidade)
                .ToListAsync();

            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost]
        [Route("estaduais")]
        public async Task<IActionResult> PostFeriadoEstadualAsync([FromServices] DataContext dataContext, [FromBody] PostFeriadoEstadualViewModel postFeriadoEstadual)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var feriadoEstadual = new FeriadoEstadual
            {
                Id = dataContext.FeriadosEstaduais.Count() + 1,
                Uf = postFeriadoEstadual.Uf,
                Data = new DateTime(1900, postFeriadoEstadual.Data.Month, postFeriadoEstadual.Data.Day),
                Nome = postFeriadoEstadual.Nome,
                FixoMovel = postFeriadoEstadual.FixoMovel
            };

            try
            {
                await dataContext
                    .FeriadosEstaduais
                    .AddAsync(feriadoEstadual);
                await dataContext.SaveChangesAsync();

                return Created($"v1/[controller]/estaduais/{feriadoEstadual.Uf}", feriadoEstadual);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Message: {ex.Message} || InnerException: {ex.InnerException}");
            }
        }
    }
}

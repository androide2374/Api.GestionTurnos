using Api.GestionTurnos.Models.Salud;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Api.GestionTurnos.Models.ModelSaludContext;

namespace Api.GestionTurnos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnosController : Controller
    {
        private readonly SaludContext _saludContext;
        public TurnosController(SaludContext saludContext)
        {
            _saludContext = saludContext;
        }
        [HttpGet]
        public async Task<ActionResult> GetTurnos(int documento)
        {
            var a = await _saludContext.TurnosSaluds.FromSqlRaw<TurnosSalud>($"execute BuscarTurnosxDNI '{documento}'").ToListAsync();
            return Ok(a);
        }
    }
}

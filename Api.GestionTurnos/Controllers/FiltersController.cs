using Api.GestionTurnos.Models;
using Api.GestionTurnos.Models.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.GestionTurnos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiltersController : ControllerBase
    {
        private readonly SiteMLZContext _context;
        public FiltersController(SiteMLZContext context)
        {
            _context = context;
        }
        [HttpGet("Sexo")]
        public async Task<IActionResult> Sexo()
        {
            List<Sexo> sexo = await _context.Sexos.ToListAsync();
            return Ok(sexo);
        }
        [HttpGet("Localidad")]
        public async Task<IActionResult> Localidad(int idProvincia)
        {
            List<Localidad> localidads = await _context.Localidads.Where(x => x.IdProvincia == idProvincia).ToListAsync();
            return Ok(localidads);
        }
        [HttpGet("Provincia")]
        public async Task<IActionResult> Provincia()
        {
            List<Provincia> provincias = await _context.Provincias.ToListAsync();
            return Ok(provincias);
        }
    }
}

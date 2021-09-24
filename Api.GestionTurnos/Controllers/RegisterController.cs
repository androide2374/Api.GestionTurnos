using Api.GestionTurnos.Models;
using Api.GestionTurnos.Models.Request;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.GestionTurnos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly SiteMLZContext _context;
        private readonly IMapper _mapper;
        public RegisterController(SiteMLZContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterReq req)
        {
            UsuariosWeb usuario = _context.UsuariosWebs.Where(x => x.Email == req.Email || x.Documento == req.Documento || x.Username == req.Username).FirstOrDefault();
            if (usuario == null)
            {
                UsuariosWeb newUser = _mapper.Map<UsuariosWeb>(req);
                await _context.UsuariosWebs.AddAsync(newUser);
                await _context.SaveChangesAsync();
                return Ok(req);
            }
            else
            {
                return BadRequest("Algunos datos ya existen en nuestra base de datos");
            }
            
        }
    }
}

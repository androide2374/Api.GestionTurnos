using Api.GestionTurnos.Models;
using Api.GestionTurnos.Models.Request;
using Api.GestionTurnos.Models.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestionTurnos.Controllers
{
    public class LoginController : Controller
    {

        private readonly SiteMLZContext _context;
        private readonly TokenGenerator _tokenGenerator;
        public LoginController(SiteMLZContext context, TokenGenerator tokenGenerator)
        {
            _tokenGenerator = tokenGenerator;
            _context = context;
        }
        [HttpPost("Login")]
        public ActionResult Login([FromBody] LoginReq req)
        {

            var User = _context.UsuariosWebs.Where(x => x.Username == req.Usuario || x.Email == req.Usuario).FirstOrDefault();
            var pass = Encryption.Encrypt(req.Password);
            if (User != null)
            {
                if (User.Password == pass)
                {
                    var token = _tokenGenerator.GenerateTokenJwt(req.Usuario);
                    var res = new LoginRes() { Apellido = User.Apellido, Nombre = User.Nombre, Token = token, Username = User.Username };

                    return Ok(res);
                }

            }
            return Unauthorized("Usuario o contraseña incorrecto");
        }
    }
}

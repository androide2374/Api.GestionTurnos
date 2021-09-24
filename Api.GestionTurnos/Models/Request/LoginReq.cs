using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.GestionTurnos.Models.Request
{
    public class LoginReq
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
    }
}

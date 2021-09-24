using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class User
    {
        public User()
        {
            UserRols = new HashSet<UserRol>();
        }

        public int Id { get; set; }
        public string Usuario { get; set; }
        public string PasswordHash { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool EsInterno { get; set; }
        public bool Active { get; set; }
        public string Foto { get; set; }

        public virtual ICollection<UserRol> UserRols { get; set; }
    }
}

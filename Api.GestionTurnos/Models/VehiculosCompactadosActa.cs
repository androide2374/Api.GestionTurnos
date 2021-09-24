using System;
using System.Collections.Generic;

#nullable disable

namespace Api.GestionTurnos.Models
{
    public partial class VehiculosCompactadosActa
    {
        public int Id { get; set; }
        public DateTime? FechaActa { get; set; }
        public string NumeroActa { get; set; }
        public string Serie { get; set; }
        public int? IdTipoVehiculo { get; set; }
        public string MarcaModelo { get; set; }
        public string Dominio { get; set; }
        public string Chasis { get; set; }
        public string Motor { get; set; }
        public string ApellidoNombre { get; set; }
        public string Domicilio { get; set; }
        public int? IdLocalidad { get; set; }
        public string CodigoPostal { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? BajaLogica { get; set; }
        public int? IdStatus { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
    }
}

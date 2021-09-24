using Api.GestionTurnos.Controllers;
using Api.GestionTurnos.Models;
using Api.GestionTurnos.Models.Request;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.GestionTurnos.MapperConfiguration
{
    public class RegisterProfile : Profile
    {
        public RegisterProfile()
        {
            CreateMap<RegisterReq, UsuariosWeb>().BeforeMap((src, dest) => src.Password = Encryption.Encrypt(src.Password));
            CreateMap<UsuariosWeb, RegisterReq>().BeforeMap((src, dest) => src.Password = Encryption.Encrypt(src.Password));
        }
    }
}

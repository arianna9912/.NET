using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class UsuarioRegisterDto
    {
        public string Correo { get; set; }
        public string Password { get; set; }     
        public string Nombre { get; set; }
    }
}
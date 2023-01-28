using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class UsuarioLoginDto
    {
        public string correo { get; set; }   
        public string Password { get; set; }
    }
}
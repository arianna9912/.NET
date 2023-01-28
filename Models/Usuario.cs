using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Usuario
    {
        public int Id {get;set;}
        public string Nombre { get; set; }
        public string Correo { get; set; }
         public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        
    }
}
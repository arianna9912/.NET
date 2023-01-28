using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
namespace API.Data
{
    public interface IAuthRepository
    {
         Task<Usuario> Registrar( Usuario usuario, string password);
         Task<Usuario> Login(string Correo, string password);
         Task<bool> ExisteUsuario(string correo);
         
    }
}
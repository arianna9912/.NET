using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ProductoCreateDto
    {
        public string ? Nombre {get;set;}
        public string ? Descripcion {get;set;}
        public Decimal Precio {get;set;}
    }
}
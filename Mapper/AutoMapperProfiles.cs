using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using API.Dtos;
using API.Models;

namespace API.Mapper
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            //POST o CREATE
            CreateMap<ProductoCreateDto,Producto>();
            //PUT o UPDATE
            CreateMap<ProductoUpdateDto,Producto>();
            //GET o LIST
            CreateMap<Producto,ProductoToListDto>();

            //Users
           CreateMap<UsuarioRegisterDto,Usuario>();

           CreateMap<UsuarioLoginDto,Usuario>();
           
           CreateMap<Usuario,UsuarioListDto>(); 
        }
       
    }
}
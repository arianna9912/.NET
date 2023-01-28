using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Models;
 namespace API.Data
{
    public class DataContext:DbContext
    {
       
      public DataContext (DbContextOptions<DataContext> options) :base(options)
        {
        //  protected override void OnConfiguring(DbContextOptionsBuilder options){
          //  options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
          //}
        }

        public DbSet<Producto> Productos {get;set;}
        public DbSet<Usuario> Usuarios {get;set;}
    }
}
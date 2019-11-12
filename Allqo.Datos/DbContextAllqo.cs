using System;
using System.Collections.Generic;
using System.Text;
using Allqo.Datos.Mapping;
using Allqo.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Allqo.Datos
{
    public class DbContextAllqo : DbContext
    {
        public DbSet<Servicio> Servicios { get; set; }        
        public DbContextAllqo(DbContextOptions<DbContextAllqo> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ServicioMap());
        }

    }
}

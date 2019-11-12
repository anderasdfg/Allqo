using Microsoft.EntityFrameworkCore;
using Allqo.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Allqo.Datos.Mapping
{
    public class ServicioMap : IEntityTypeConfiguration<Servicio>
    {
        public void Configure(EntityTypeBuilder<Servicio> builder)
        {
            builder.ToTable("servicio")
                .HasKey(s => s.idServicio);
         }
    }
}

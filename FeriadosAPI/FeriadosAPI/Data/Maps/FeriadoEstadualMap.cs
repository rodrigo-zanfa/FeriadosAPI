using FeriadosAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeriadosAPI.Data.Maps
{
    public class FeriadoEstadualMap : IEntityTypeConfiguration<FeriadoEstadual>
    {
        public void Configure(EntityTypeBuilder<FeriadoEstadual> builder)
        {
            builder.ToTable("APIFeriadoEstadual");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Data)
                .IsRequired();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(x => x.FixoMovel)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(1);

            builder.Property(x => x.Uf)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(2);
        }
    }
}

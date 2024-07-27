using CursoEF.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF.Infra.Configurations;
public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Nome).HasColumnType("VARCHAR(50)").IsRequired();
        builder.Property(c => c.Telefone).HasColumnType("CHAR(11)");
        builder.Property(c => c.CEP).HasColumnType("CHAR(8)"); //somente numeros
        builder.Property(c => c.Cidade).HasColumnType("VARCHAR(25)");
        builder.Property(c => c.Estado).HasColumnType("VARCHAR(3)");
        builder.HasIndex(i => i.Telefone).HasName("indice_cliente_telefone");

    }
}


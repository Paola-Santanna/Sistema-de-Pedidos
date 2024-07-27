using CursoEF.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF.Infra.Configurations;
public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
{
    public void Configure(EntityTypeBuilder<Pedido> builder)
    {
        builder.ToTable("Pedidos");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.ClienteId).HasColumnType("INT");
        builder.Ignore(p => p.Cliente);
        builder.Property(p => p.IniciadoEm).HasConversion<DateTime>();
        builder.Property(p => p.FinalizadoEm).HasConversion<DateTime>();
        builder.Property(p => p.StatusPedido).HasConversion<string>();
        builder.Property(p => p.TipoFrete).HasConversion<string>();
        builder.Property(p => p.Observacao).HasColumnType("VARCHAR(50)");
        builder.Ignore(p => p.Itens);
    }
}


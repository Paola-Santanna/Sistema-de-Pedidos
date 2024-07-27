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
public class PedidoItemConfiguration : IEntityTypeConfiguration<PedidoItem>
{
    public void Configure(EntityTypeBuilder<PedidoItem> builder)
    {
        builder.ToTable("Itens");
        builder.HasKey(p => p.Id);
        builder.Property(i => i.Quantidade).HasDefaultValue(1).IsRequired();
        builder.Property(i => i.Valor).IsRequired();
        builder.Property(i => i.Desconto).IsRequired();

    }
}


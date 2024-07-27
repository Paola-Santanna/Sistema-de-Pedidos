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
public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.ToTable("Produtos");
        builder.HasKey(pd => pd.Id);
        builder.Property(pd => pd.CodigoDeBarras).HasColumnType("VARCHAR(14)").IsRequired();
        builder.Property(pd => pd.Descricao).HasColumnType("VARCHAR(60)");
        builder.Property(pd => pd.Valor).IsRequired();
        builder.Property(pd => pd.TipoProduto).HasConversion<string>();
        builder.Property(pd => pd.Ativo).HasConversion<bool>();
    }
}


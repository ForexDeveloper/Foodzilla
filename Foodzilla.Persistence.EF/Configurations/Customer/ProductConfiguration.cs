using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.Customer;
using Foodzilla.Kernel.Persistence.EF.Commons;
using Foodzilla.Kernel.Persistence.EF.Configurations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.Customer;

public sealed class ProductConfiguration : EntityConfiguration<Product>
{
    public override void Configure(EntityTypeBuilder<Product> builder)
    {
        base.Configure(builder);

        builder.Property(p => p.Sku).HasMaxLength(ColumnLength.Length1024).IsRequired();
        builder.Property(p => p.Title).HasMaxLength(ColumnLength.Length500).IsRequired();
        builder.Property(p => p.Price).HasColumnType(ColumnType.Decimal(18, 2)).IsRequired();
        builder.Property(p => p.Description).HasMaxLength(ColumnLength.MaxLength).IsRequired();
    }
}
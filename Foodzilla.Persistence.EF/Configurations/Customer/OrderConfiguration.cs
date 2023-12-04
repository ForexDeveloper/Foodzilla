using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.Customer;
using Foodzilla.Kernel.Persistence.EF.Commons;
using Foodzilla.Kernel.Persistence.EF.Configurations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.Customer;

public sealed class OrderConfiguration : EntityConfiguration<Order>
{
    public override void Configure(EntityTypeBuilder<Order> builder)
    {
        base.Configure(builder);

        builder.Property(p => p.OrderDate).HasColumnType(ColumnType.DateTimeOffset).IsRequired();

        builder.HasOne(p => p.Customer)
               .WithMany(p => p.Orders)
               .HasForeignKey(p => p.CustomerId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(p => p.Product)
               .WithMany(p => p.Orders)
               .HasForeignKey(p => p.ProductId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
namespace Foodzilla.Persistence.EF.Configurations.Customer;

using Foodzilla.Domain.Aggregates.Customer;
using Foodzilla.Kernel.Persistence.EF.Commons;
using Foodzilla.Kernel.Persistence.EF.Configurations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public sealed class CustomerConfiguration : EntityConfiguration<Customer>
{
    public override void Configure(EntityTypeBuilder<Customer> builder)
    {
        base.Configure(builder);

        builder.Property(p => p.Name).HasMaxLength(ColumnLength.Length250).IsRequired();
        builder.Property(p => p.Family).HasMaxLength(ColumnLength.Length250).IsRequired();
        builder.Property(p => p.NationalCode).HasMaxLength(ColumnLength.Length100).IsRequired();

        builder.Property(p => p.String).IsRequired();
        builder.Property(p => p.StringNullable).IsRequired(false);

        builder.Property(p => p.Boolean).IsRequired();
        builder.Property(p => p.BooleanNullable).IsRequired(false);

        builder.Property(p => p.Int).IsRequired();
        builder.Property(p => p.IntNullable).IsRequired(false);

        builder.Property(p => p.Long).IsRequired();
        builder.Property(p => p.LongNullable).IsRequired(false);

        builder.Property(p => p.Double).IsRequired();
        builder.Property(p => p.DoubleNullable).IsRequired(false);

        builder.Property(p => p.CustomerRank).IsRequired();
        builder.Property(p => p.CustomerRankNullable).IsRequired(false);

        builder.Property(p => p.DateTime).IsRequired();
        builder.Property(p => p.DateTimeNullable).IsRequired(false);
    }
}
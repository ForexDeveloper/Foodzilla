using Foodzilla.Kernel.Domain;
using Foodzilla.Domain.Aggregates;
using Microsoft.EntityFrameworkCore;
using Foodzilla.Kernel.Persistence.EF.Commons;
using Foodzilla.Kernel.Persistence.EF.Configurations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations;

public abstract class IdentityConfiguration<TEntity> : EntityConfiguration<TEntity> where TEntity : Entity, IIdentity
{
    public override void Configure(EntityTypeBuilder<TEntity> builder)
    {
        //builder.Property("Id").ValueGeneratedNever();

        builder.Property(p => p.Age).IsRequired();
        builder.Property(p => p.IsFired).IsRequired();
        builder.Property(p => p.Height).IsRequired(false);
        builder.Property(p => p.Weight).IsRequired(false);
        builder.Property(p => p.UniqueIdentifier).IsRequired();
        builder.Property(p => p.DaysOfVacation).IsRequired(false);

        builder.Property(p => p.Graduation).HasConversion<int>().IsRequired();
        builder.Property(p => p.Experience).HasConversion<int>().IsRequired();
        builder.Property(p => p.EyeColor).HasConversion<int>().IsRequired(false);

        builder.Property(p => p.Name).HasMaxLength(ColumnLength.Length250).IsRequired();
        builder.Property(p => p.Address).HasMaxLength(ColumnLength.MaxLength).IsRequired();
        builder.Property(p => p.LastName).HasMaxLength(ColumnLength.Length250).IsRequired();
        builder.Property(p => p.PersonalCode).HasMaxLength(ColumnLength.Length20).IsRequired();
        builder.Property(p => p.NationalCode).HasMaxLength(ColumnLength.Length128).IsRequired();

        builder.Property(p => p.BirthDate).HasColumnType(ColumnType.DateTimeOffset).IsRequired();
        builder.Property(p => p.ContractDateEnd).HasColumnType(ColumnType.DateTimeOffset).IsRequired();
        builder.Property(p => p.ContractDateStart).HasColumnType(ColumnType.DateTimeOffset).IsRequired();
        builder.Property(p => p.ModifiedDate).HasColumnType(ColumnType.DateTimeOffset).IsRequired(false);

        base.Configure(builder);
    }
}
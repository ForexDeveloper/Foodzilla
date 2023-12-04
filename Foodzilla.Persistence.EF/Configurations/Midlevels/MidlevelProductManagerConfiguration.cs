using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.Midlevels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.Midlevels;

public sealed class MidlevelProductManagerConfiguration : IdentityConfiguration<MidlevelProductManager>
{
    public override void Configure(EntityTypeBuilder<MidlevelProductManager> builder)
    {
        builder.HasOne(p => p.SeniorProductManager)
               .WithMany(p => p.Midlevels)
               .HasForeignKey(p => p.SeniorProductManagerId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
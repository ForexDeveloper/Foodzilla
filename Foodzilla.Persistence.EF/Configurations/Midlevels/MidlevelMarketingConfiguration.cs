using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.Midlevels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.Midlevels;

public sealed class MidlevelMarketingConfiguration : IdentityConfiguration<MidlevelMarketing>
{
    public override void Configure(EntityTypeBuilder<MidlevelMarketing> builder)
    {
        builder.HasOne(p => p.SeniorMarketing)
               .WithMany(p => p.Midlevels)
               .HasForeignKey(p => p.SeniorMarketingId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
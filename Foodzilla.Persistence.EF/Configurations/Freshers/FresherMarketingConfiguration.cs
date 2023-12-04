using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.Freshers;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.Freshers;

public sealed class FresherMarketingConfiguration : IdentityConfiguration<FresherMarketing>
{
    public override void Configure(EntityTypeBuilder<FresherMarketing> builder)
    {
        builder.HasOne(p => p.JuniorMarketing)
               .WithMany(p => p.Freshers)
               .HasForeignKey(p => p.JuniorMarketingId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
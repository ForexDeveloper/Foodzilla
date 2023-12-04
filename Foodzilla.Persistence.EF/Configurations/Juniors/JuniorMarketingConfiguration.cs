using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.Juniors;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.Juniors;

public sealed class JuniorMarketingConfiguration : IdentityConfiguration<JuniorMarketing>
{
    public override void Configure(EntityTypeBuilder<JuniorMarketing> builder)
    {
        builder.HasOne(p => p.MidlevelMarketing)
               .WithMany(p => p.Juniors)
               .HasForeignKey(p => p.MidlevelMarketingId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
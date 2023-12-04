using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.Seniors;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.Seniors;

public sealed class SeniorMarketingConfiguration : IdentityConfiguration<SeniorMarketing>
{
    public override void Configure(EntityTypeBuilder<SeniorMarketing> builder)
    {
        builder.HasOne(p => p.MarketingTeamLead)
               .WithMany(p => p.Seniors)
               .HasForeignKey(p => p.MarketingTeamLeadId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
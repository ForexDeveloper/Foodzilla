using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.TeamLeads;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.TeamLeads;

public sealed class MarketingTeamLeadConfiguration : IdentityConfiguration<MarketingTeamLead>
{
    public override void Configure(EntityTypeBuilder<MarketingTeamLead> builder)
    {
        builder.HasOne(p => p.ChiefMarketingOfficer)
               .WithMany(p => p.MarketingTeamLeads)
               .HasForeignKey(p => p.ChiefMarketingOfficerId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.TeamLeads;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.TeamLeads;

public sealed class TechnicalTeamLeadConfiguration : IdentityConfiguration<TechnicalTeamLead>
{
    public override void Configure(EntityTypeBuilder<TechnicalTeamLead> builder)
    {
        builder.HasOne(p => p.ChiefTechnicalOfficer)
               .WithMany(p => p.TechnicalTeamLeads)
               .HasForeignKey(p => p.ChiefTechnicalOfficerId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
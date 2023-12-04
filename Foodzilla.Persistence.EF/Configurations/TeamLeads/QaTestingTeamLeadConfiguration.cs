using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.TeamLeads;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.TeamLeads;

public sealed class QaTestingTeamLeadConfiguration : IdentityConfiguration<QaTestingTeamLead>
{
    public override void Configure(EntityTypeBuilder<QaTestingTeamLead> builder)
    {
        builder.HasOne(p => p.ChiefTechnicalOfficer)
               .WithMany(p => p.QaTestingTeamLeads)
               .HasForeignKey(p => p.ChiefTechnicalOfficerId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
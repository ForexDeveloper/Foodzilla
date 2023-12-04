using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.TeamLeads;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.TeamLeads;

public sealed class ScrumMasterTeamLeadConfiguration : IdentityConfiguration<ScrumMasterTeamLead>
{
    public override void Configure(EntityTypeBuilder<ScrumMasterTeamLead> builder)
    {
        builder.HasOne(p => p.ChiefProductOfficer)
               .WithMany(p => p.ScrumMasterTeamLeads)
               .HasForeignKey(p => p.ChiefProductOfficerId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
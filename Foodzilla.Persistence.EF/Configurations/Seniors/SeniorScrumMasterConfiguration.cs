using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.Seniors;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.Seniors;

public sealed class SeniorScrumMasterConfiguration : IdentityConfiguration<SeniorScrumMaster>
{
    public override void Configure(EntityTypeBuilder<SeniorScrumMaster> builder)
    {
        builder.HasOne(p => p.ScrumMasterTeamLead)
               .WithMany(p => p.Seniors)
               .HasForeignKey(p => p.ScrumMasterTeamLeadId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
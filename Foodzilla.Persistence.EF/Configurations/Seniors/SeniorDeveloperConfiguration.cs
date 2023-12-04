using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.Seniors;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.Seniors;

public sealed class SeniorDeveloperConfiguration : IdentityConfiguration<SeniorDeveloper>
{
    public override void Configure(EntityTypeBuilder<SeniorDeveloper> builder)
    {
        builder.HasOne(p => p.TechnicalTeamLead)
               .WithMany(p => p.Seniors)
               .HasForeignKey(p => p.TechnicalTeamLeadId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
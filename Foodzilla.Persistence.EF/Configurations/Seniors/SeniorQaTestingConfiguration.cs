using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.Seniors;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.Seniors;

public sealed class SeniorQaTestingConfiguration : IdentityConfiguration<SeniorQaTesting>
{
    public override void Configure(EntityTypeBuilder<SeniorQaTesting> builder)
    {
        builder.HasOne(p => p.QaTestingTeamLead)
               .WithMany(p => p.Seniors)
               .HasForeignKey(p => p.QaTestingTeamLeadId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
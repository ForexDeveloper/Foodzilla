using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.Seniors;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.Seniors;

public sealed class SeniorProductConfiguration : IdentityConfiguration<SeniorProductManager>
{
    public override void Configure(EntityTypeBuilder<SeniorProductManager> builder)
    {
        builder.HasOne(p => p.ProductTeamLead)
               .WithMany(p => p.Seniors)
               .HasForeignKey(p => p.ProductTeamLeadId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
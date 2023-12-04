using Foodzilla.Kernel.Persistence.EF.Commons;
using Foodzilla.Domain.Aggregates.ChiefOfficers;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.ChiefOfficers;

public sealed class ChiefMarketingOfficerConfiguration : IdentityConfiguration<ChiefMarketingOfficer>
{
    public override void Configure(EntityTypeBuilder<ChiefMarketingOfficer> builder)
    {
        builder.Property(p => p.AssignedOrganization).HasMaxLength(ColumnLength.Length250).IsRequired();
    }
}
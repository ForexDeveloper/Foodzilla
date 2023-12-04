using Foodzilla.Domain.Aggregates.ChiefOfficers;
using Foodzilla.Kernel.Persistence.EF.Commons;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.ChiefOfficers;

public sealed class ChiefExecutiveOfficerConfiguration : IdentityConfiguration<ChiefExecutiveOfficer>
{
    public override void Configure(EntityTypeBuilder<ChiefExecutiveOfficer> builder)
    {
        builder.Property(p => p.AssignedOrganization).HasMaxLength(ColumnLength.Length250).IsRequired();
    }
}
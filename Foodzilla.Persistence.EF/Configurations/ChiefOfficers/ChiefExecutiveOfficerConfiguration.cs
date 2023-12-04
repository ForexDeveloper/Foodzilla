using Microsoft.EntityFrameworkCore;
using Foodzilla.Kernel.Persistence.EF.Commons;
using Foodzilla.Domain.Aggregates.ChiefOfficers;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.ChiefOfficers;

public sealed class ChiefExecutiveOfficerConfiguration : IdentityConfiguration<ChiefExecutiveOfficer>
{
    public override void Configure(EntityTypeBuilder<ChiefExecutiveOfficer> builder)
    {
        builder.Property(p => p.AssignedOrganization).HasMaxLength(ColumnLength.Length250).IsRequired();

        builder.HasOne(p => p.ChiefMarketingOfficer)
               .WithOne(p => p.ChiefExecutiveOfficer)
               .HasForeignKey<ChiefMarketingOfficer>()
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(p => p.ChiefProductOfficer)
               .WithOne(p => p.ChiefExecutiveOfficer)
               .HasForeignKey<ChiefProductOfficer>()
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(p => p.ChiefTechnicalOfficer)
               .WithOne(p => p.ChiefExecutiveOfficer)
               .HasForeignKey<ChiefTechnicalOfficer>()
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.TeamLeads;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.TeamLeads;

public sealed class ProductTeamLeadConfiguration : IdentityConfiguration<ProductTeamLead>
{
    public override void Configure(EntityTypeBuilder<ProductTeamLead> builder)
    {
        builder.HasOne(p => p.ChiefProductOfficer)
               .WithMany(p => p.ProductTeamLeads)
               .HasForeignKey(p => p.ChiefProductOfficerId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
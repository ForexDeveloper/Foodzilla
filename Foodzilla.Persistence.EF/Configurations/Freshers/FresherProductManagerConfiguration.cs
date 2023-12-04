using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.Freshers;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.Freshers;

public sealed class FresherProductManagerConfiguration : IdentityConfiguration<FresherProductManager>
{
    public override void Configure(EntityTypeBuilder<FresherProductManager> builder)
    {
        builder.HasOne(p => p.JuniorProductManager)
               .WithMany(p => p.Freshers)
               .HasForeignKey(p => p.JuniorProductManagerId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
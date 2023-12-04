using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.Freshers;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.Freshers;

public sealed class FresherDeveloperConfiguration : IdentityConfiguration<FresherDeveloper>
{
    public override void Configure(EntityTypeBuilder<FresherDeveloper> builder)
    {
        builder.HasOne(p => p.JuniorDeveloper)
               .WithMany(p => p.Freshers)
               .HasForeignKey(p => p.JuniorDeveloperId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.Midlevels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.Midlevels;

public sealed class MidlevelDeveloperConfiguration : IdentityConfiguration<MidlevelDeveloper>
{
    public override void Configure(EntityTypeBuilder<MidlevelDeveloper> builder)
    {
        builder.HasOne(p => p.SeniorDeveloper)
               .WithMany(p => p.Midlevels)
               .HasForeignKey(p => p.SeniorDeveloperId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
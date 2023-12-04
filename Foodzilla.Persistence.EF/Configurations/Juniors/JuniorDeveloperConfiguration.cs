using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.Juniors;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.Juniors;

public sealed class JuniorDeveloperConfiguration : IdentityConfiguration<JuniorDeveloper>
{
    public override void Configure(EntityTypeBuilder<JuniorDeveloper> builder)
    {
        builder.HasOne(p => p.MidlevelDeveloper)
               .WithMany(p => p.Juniors)
               .HasForeignKey(p => p.MidlevelDeveloperId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
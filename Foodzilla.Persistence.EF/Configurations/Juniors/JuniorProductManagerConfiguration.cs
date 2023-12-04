using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.Juniors;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Foodzilla.Persistence.EF.Configurations.Juniors;

public sealed class JuniorProductManagerConfiguration : IdentityConfiguration<JuniorProductManager>
{
    public override void Configure(EntityTypeBuilder<JuniorProductManager> builder)
    {
        builder.HasOne(p => p.MidlevelProductManager)
               .WithMany(p => p.Juniors)
               .HasForeignKey(p => p.MidlevelProductManagerId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
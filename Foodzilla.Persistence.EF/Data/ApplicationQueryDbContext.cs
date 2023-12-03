using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.Customer;

namespace Foodzilla.Persistence.EF.Data;

public sealed class ApplicationQueryDbContext : DbContext
{
    public ApplicationQueryDbContext(DbContextOptions<ApplicationQueryDbContext> options) : base(options)
    {

    }

    private ApplicationQueryDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Order> Orders { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
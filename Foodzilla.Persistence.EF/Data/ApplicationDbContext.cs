namespace Foodzilla.Persistence.EF.Data;

using Microsoft.EntityFrameworkCore;
using Foodzilla.Kernel.Commons.Credentials;
using Foodzilla.Domain.Aggregates.Customer;
using Foodzilla.Kernel.Persistence.EF.Provider;

public class ApplicationDbContext : DbContext
{
    private const string UserName = "sa";
    private const string DbName = "Foodzilla";
    private const string ServerAddress = "localhost";
    private const string Password = "P@ssw0rdP@ssw0rd";

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    protected ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var credential = SqlCredential.Create(DbName, UserName, Password, ServerAddress);

            var connectionString = Connection.GetConfiguration(credential);

            optionsBuilder.UseSqlServer(connectionString);
        }

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //new ApplicationDbContextInitializer(modelBuilder).Seed();
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
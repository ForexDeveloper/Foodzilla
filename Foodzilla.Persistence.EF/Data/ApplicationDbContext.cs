namespace Foodzilla.Persistence.EF.Data;

using Microsoft.EntityFrameworkCore;
using Foodzilla.Domain.Aggregates.Freshers;
using Foodzilla.Domain.Aggregates.Juniors;
using Foodzilla.Domain.Aggregates.Midlevels;
using Foodzilla.Domain.Aggregates.Seniors;
using Foodzilla.Domain.Aggregates.TeamLeads;
using Foodzilla.Kernel.Commons.Credentials;
using Foodzilla.Domain.Aggregates.Customer;
using Foodzilla.Kernel.Persistence.EF.Provider;
using Foodzilla.Domain.Aggregates.ChiefOfficers;

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

    public virtual DbSet<ChiefExecutiveOfficer> ChiefExecutiveOfficers { get; set; }

    public virtual DbSet<ChiefTechnicalOfficer> ChiefTechnicalOfficers { get; set; }

    public virtual DbSet<ChiefProductOfficer> ChiefProductOfficers { get; set; }

    public virtual DbSet<ChiefMarketingOfficer> ChiefMarketingOfficers { get; set; }

    public virtual DbSet<TechnicalTeamLead> TechnicalTeamLeads { get; set; }

    public virtual DbSet<ProductTeamLead> ProductTeamLeads { get; set; }

    public virtual DbSet<MarketingTeamLead> MarketingTeamLeads { get; set; }

    public virtual DbSet<ScrumMasterTeamLead> ScrumMasterTeamLeads { get; set; }

    public virtual DbSet<QaTestingTeamLead> QaTestingTeamLeads { get; set; }

    public virtual DbSet<SeniorDeveloper> SeniorDevelopers { get; set; }

    public virtual DbSet<SeniorProductManager> SeniorProductManagers { get; set; }

    public virtual DbSet<SeniorMarketing> SeniorMarketings { get; set; }

    public virtual DbSet<SeniorQaTesting> SeniorQaTestings { get; set; }

    public virtual DbSet<SeniorScrumMaster> SeniorScrumMasters { get; set; }

    public virtual DbSet<MidlevelDeveloper> MidlevelDevelopers { get; set; }

    public virtual DbSet<MidlevelProductManager> MidlevelProductManagers { get; set; }

    public virtual DbSet<MidlevelMarketing> MidlevelMarketings { get; set; }

    public virtual DbSet<JuniorDeveloper> JuniorDevelopers { get; set; }

    public virtual DbSet<JuniorMarketing> JuniorMarketings { get; set; }

    public virtual DbSet<JuniorProductManager> JuniorProductManagers { get; set; }

    public virtual DbSet<FresherDeveloper> FresherDevelopers { get; set; }

    public virtual DbSet<FresherMarketing> FresherMarketings { get; set; }

    public virtual DbSet<FresherProductManager> FresherProductManagers { get; set; }

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
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Foodzilla.Kernel.Commons.Credentials;
using Foodzilla.Kernel.Persistence.EF.Provider;

namespace Foodzilla.Persistence.EF.Data;

public class SqlServerDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    protected const string UserName = "sa";
    protected const string DbName = "Foodzilla";
    protected const string ServerAddress = "localhost";
    protected const string Password = "P@ssw0rdP@ssw0rd";

    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var credential = SqlCredential.Create(DbName, UserName, Password, ServerAddress);

        var builder = new DbContextOptionsBuilder<ApplicationDbContext>();

        var connectionString = args.Any() ? args[0] : Connection.GetConfiguration(credential);

        builder.UseSqlServer(connectionString, p => p.MigrationsAssembly(typeof(SqlServerDbContextFactory).Assembly.GetName().Name));

        return new ApplicationDbContext(builder.Options);
    }
}
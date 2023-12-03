using Foodzilla.Kernel;
using Foodzilla.Persistence.EF.Data;
using Foodzilla.Kernel.Persistence.EF;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Foodzilla.Persistence.EF;

public sealed class StartupModule : StartupModuleBase
{
    public override void Execute(IServiceCollection services, IConfiguration configuration)
    {
        //var credential = configuration.GetSection(nameof(SqlCredential)).Get<SqlCredential>();
        //services.AddSqlServerDbContext<ApplicationDbContext>(credential, p => p.MigrationsAssembly(typeof(StartupModule).Assembly.GetName().Name));

        services.AddSqlServerDbContext<ApplicationDbContext>(configuration, p => p.MigrationsAssembly(typeof(StartupModule).Assembly.GetName().Name));

        services.AddSqlServerDbContext<ApplicationQueryDbContext>(configuration, p => p.MigrationsAssembly(typeof(StartupModule).Assembly.GetName().Name));
    }
}
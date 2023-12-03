using Foodzilla.Kernel;
using Foodzilla.Kernel.Persistence.Redis;
using Microsoft.Extensions.Configuration;
using Foodzilla.Kernel.Commons.Credentials;
using Microsoft.Extensions.DependencyInjection;

namespace Foodzilla.Persistence.Redis;

public sealed class StartupModule : StartupModuleBase
{
    public override void Execute(IServiceCollection services, IConfiguration configuration)
    {
        //var credential = configuration.GetSection("RedisCredential").Get<RedisCredential>();
        //services.AddRedisConnectionProvider(credential);

        services.AddRedisConnectionProvider(configuration);
    }
}
﻿using Foodzilla.Kernel;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Foodzilla.Persistence.Dapper;

public sealed class StartupModule : StartupModuleBase
{
    public override void Execute(IServiceCollection services, IConfiguration configuration)
    {
    }
}
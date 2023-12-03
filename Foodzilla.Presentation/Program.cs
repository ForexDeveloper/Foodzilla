using Foodzilla.Kernel;
using Foodzilla.Persistence.EF.Extensions;
using Foodzilla.Presentation.GrpcServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

const string applicationName = "OFood";

var services = builder.Services;

services.InjectStartupModules(builder.Configuration);

services.ScanInjections();

services.AddGrpc();

services.AddEndpointsApiExplorer();

services.AddSwaggerGen(option =>
{
    option.SwaggerDoc(applicationName, new OpenApiInfo
    {
        Title = "OFood Swagger",
        Version = "v1"
    });
    option.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
});

services.AddControllers();

services.AddApiVersioning(o =>
{
    o.ReportApiVersions = true;
    o.AssumeDefaultVersionWhenUnspecified = true;
    o.DefaultApiVersion = new ApiVersion(1, 0);
    o.ApiVersionReader = new UrlSegmentApiVersionReader();
});

//await services.MigrateAsync<ApplicationDbContext>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseRouting();

app.UseSwagger(x => x.SerializeAsV2 = true);

app.UseSwaggerUI(option =>
{
    option.RoutePrefix = string.Empty;
    option.DocumentTitle = "OFood Swagger";
    option.SwaggerEndpoint($"/swagger/{applicationName}/swagger.json", "Swagger v1 Api");
});


app.UseEndpoints(option =>
{
    option.MapControllers();
    option.MapGrpcService<CustomerService>();
});

app.Seed();

app.Run();
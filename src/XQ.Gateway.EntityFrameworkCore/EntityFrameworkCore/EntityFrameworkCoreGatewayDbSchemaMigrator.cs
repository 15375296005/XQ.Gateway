using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using XQ.Gateway.Data;
using Volo.Abp.DependencyInjection;

namespace XQ.Gateway.EntityFrameworkCore;

public class EntityFrameworkCoreGatewayDbSchemaMigrator
    : IGatewayDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreGatewayDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the GatewayDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<GatewayDbContext>()
            .Database
            .MigrateAsync();
    }
}

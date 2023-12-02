using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace XQ.Gateway.Data;

/* This is used if database provider does't define
 * IGatewayDbSchemaMigrator implementation.
 */
public class NullGatewayDbSchemaMigrator : IGatewayDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

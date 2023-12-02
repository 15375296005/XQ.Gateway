using System.Threading.Tasks;

namespace XQ.Gateway.Data;

public interface IGatewayDbSchemaMigrator
{
    Task MigrateAsync();
}

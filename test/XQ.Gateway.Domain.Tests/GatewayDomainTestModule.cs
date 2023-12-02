using XQ.Gateway.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace XQ.Gateway;

[DependsOn(
    typeof(GatewayEntityFrameworkCoreTestModule)
    )]
public class GatewayDomainTestModule : AbpModule
{

}

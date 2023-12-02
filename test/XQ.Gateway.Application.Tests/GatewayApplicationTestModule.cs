using Volo.Abp.Modularity;

namespace XQ.Gateway;

[DependsOn(
    typeof(GatewayApplicationModule),
    typeof(GatewayDomainTestModule)
    )]
public class GatewayApplicationTestModule : AbpModule
{

}

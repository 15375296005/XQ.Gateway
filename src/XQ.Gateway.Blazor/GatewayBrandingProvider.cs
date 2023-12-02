using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace XQ.Gateway.Blazor;

[Dependency(ReplaceServices = true)]
public class GatewayBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Gateway";
}

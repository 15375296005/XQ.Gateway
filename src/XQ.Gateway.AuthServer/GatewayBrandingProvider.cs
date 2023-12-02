using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace XQ.Gateway;

[Dependency(ReplaceServices = true)]
public class GatewayBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Gateway";
}

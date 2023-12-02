using XQ.Gateway.Localization;
using Volo.Abp.AspNetCore.Components;

namespace XQ.Gateway.Blazor;

public abstract class GatewayComponentBase : AbpComponentBase
{
    protected GatewayComponentBase()
    {
        LocalizationResource = typeof(GatewayResource);
    }
}

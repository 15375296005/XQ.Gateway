using XQ.Gateway.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace XQ.Gateway.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class GatewayController : AbpControllerBase
{
    protected GatewayController()
    {
        LocalizationResource = typeof(GatewayResource);
    }
}

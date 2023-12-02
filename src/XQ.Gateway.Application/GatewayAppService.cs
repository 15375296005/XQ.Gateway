using System;
using System.Collections.Generic;
using System.Text;
using XQ.Gateway.Localization;
using Volo.Abp.Application.Services;

namespace XQ.Gateway;

/* Inherit your application services from this class.
 */
public abstract class GatewayAppService : ApplicationService
{
    protected GatewayAppService()
    {
        LocalizationResource = typeof(GatewayResource);
    }
}

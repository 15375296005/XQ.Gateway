using Volo.Abp.Settings;

namespace XQ.Gateway.Settings;

public class GatewaySettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(GatewaySettings.MySetting1));
    }
}

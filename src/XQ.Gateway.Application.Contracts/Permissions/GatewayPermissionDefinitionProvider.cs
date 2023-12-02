using XQ.Gateway.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace XQ.Gateway.Permissions;

public class GatewayPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(GatewayPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(GatewayPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<GatewayResource>(name);
    }
}

using Appricot.Abp.FileManagementModule.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Appricot.Abp.FileManagementModule.Permissions;

public class FileManagementModulePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(FileManagementModulePermissions.GroupName, L("Permission:FileManagementModule"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FileManagementModuleResource>(name);
    }
}

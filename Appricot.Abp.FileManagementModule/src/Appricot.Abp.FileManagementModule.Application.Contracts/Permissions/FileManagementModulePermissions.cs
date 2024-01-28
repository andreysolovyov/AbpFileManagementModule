using Volo.Abp.Reflection;

namespace Appricot.Abp.FileManagementModule.Permissions;

public class FileManagementModulePermissions
{
    public const string GroupName = "FileManagementModule";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(FileManagementModulePermissions));
    }
}

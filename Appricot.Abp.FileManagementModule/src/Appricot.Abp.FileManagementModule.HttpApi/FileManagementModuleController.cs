using Appricot.Abp.FileManagementModule.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Appricot.Abp.FileManagementModule;

public abstract class FileManagementModuleController : AbpControllerBase
{
    protected FileManagementModuleController()
    {
        LocalizationResource = typeof(FileManagementModuleResource);
    }
}

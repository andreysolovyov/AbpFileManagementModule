using Appricot.Abp.FileManagementModule.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Appricot.Abp.FileManagementModule.Pages;

public abstract class FileManagementModulePageModel : AbpPageModel
{
    protected FileManagementModulePageModel()
    {
        LocalizationResourceType = typeof(FileManagementModuleResource);
    }
}

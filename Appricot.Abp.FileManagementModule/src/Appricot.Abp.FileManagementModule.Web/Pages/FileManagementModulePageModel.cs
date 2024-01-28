using Appricot.Abp.FileManagementModule.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Appricot.Abp.FileManagementModule.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class FileManagementModulePageModel : AbpPageModel
{
    protected FileManagementModulePageModel()
    {
        LocalizationResourceType = typeof(FileManagementModuleResource);
        ObjectMapperContext = typeof(FileManagementModuleWebModule);
    }
}

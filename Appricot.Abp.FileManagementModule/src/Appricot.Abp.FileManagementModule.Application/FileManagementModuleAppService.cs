using Appricot.Abp.FileManagementModule.Localization;
using Volo.Abp.Application.Services;

namespace Appricot.Abp.FileManagementModule;

public abstract class FileManagementModuleAppService : ApplicationService
{
    protected FileManagementModuleAppService()
    {
        LocalizationResource = typeof(FileManagementModuleResource);
        ObjectMapperContext = typeof(FileManagementModuleApplicationModule);
    }
}

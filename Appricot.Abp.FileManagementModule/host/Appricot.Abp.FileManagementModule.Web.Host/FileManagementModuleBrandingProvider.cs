using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Appricot.Abp.FileManagementModule;

[Dependency(ReplaceServices = true)]
public class FileManagementModuleBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "FileManagementModule";
}

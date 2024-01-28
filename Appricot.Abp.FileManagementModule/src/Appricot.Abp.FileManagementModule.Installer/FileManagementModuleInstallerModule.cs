using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Appricot.Abp.FileManagementModule;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class FileManagementModuleInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<FileManagementModuleInstallerModule>();
        });
    }
}

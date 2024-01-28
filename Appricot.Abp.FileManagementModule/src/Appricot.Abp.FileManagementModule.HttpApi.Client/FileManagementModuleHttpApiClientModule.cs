using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Appricot.Abp.FileManagementModule;

[DependsOn(
    typeof(FileManagementModuleApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class FileManagementModuleHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(FileManagementModuleApplicationContractsModule).Assembly,
            FileManagementModuleRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<FileManagementModuleHttpApiClientModule>();
        });

    }
}

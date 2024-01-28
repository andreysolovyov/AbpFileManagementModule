using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Appricot.Abp.FileManagementModule;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FileManagementModuleHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class FileManagementModuleConsoleApiClientModule : AbpModule
{

}

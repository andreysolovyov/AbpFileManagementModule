using Volo.Abp.Modularity;

namespace Appricot.Abp.FileManagementModule;

[DependsOn(
    typeof(FileManagementModuleDomainModule),
    typeof(FileManagementModuleTestBaseModule)
)]
public class FileManagementModuleDomainTestModule : AbpModule
{

}

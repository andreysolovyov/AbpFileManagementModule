using Volo.Abp.Modularity;

namespace Appricot.Abp.FileManagementModule;

[DependsOn(
    typeof(FileManagementModuleApplicationModule),
    typeof(FileManagementModuleDomainTestModule)
    )]
public class FileManagementModuleApplicationTestModule : AbpModule
{

}

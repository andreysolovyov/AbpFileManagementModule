using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Appricot.Abp.FileManagementModule;

[DependsOn(
    typeof(FileManagementModuleDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class FileManagementModuleApplicationContractsModule : AbpModule
{

}

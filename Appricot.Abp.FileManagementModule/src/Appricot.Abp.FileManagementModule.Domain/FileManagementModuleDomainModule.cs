using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Appricot.Abp.FileManagementModule;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(FileManagementModuleDomainSharedModule)
)]
public class FileManagementModuleDomainModule : AbpModule
{

}

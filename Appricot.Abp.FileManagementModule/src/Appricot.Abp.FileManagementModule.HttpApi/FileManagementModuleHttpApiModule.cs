using Localization.Resources.AbpUi;
using Appricot.Abp.FileManagementModule.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Appricot.Abp.FileManagementModule;

[DependsOn(
    typeof(FileManagementModuleApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class FileManagementModuleHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(FileManagementModuleHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<FileManagementModuleResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}

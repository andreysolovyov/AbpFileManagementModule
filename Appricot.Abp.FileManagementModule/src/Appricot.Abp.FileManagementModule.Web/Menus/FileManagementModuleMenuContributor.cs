using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Appricot.Abp.FileManagementModule.Web.Menus;

public class FileManagementModuleMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(FileManagementModuleMenus.Prefix, displayName: "FileManagementModule", "~/FileManagementModule", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}

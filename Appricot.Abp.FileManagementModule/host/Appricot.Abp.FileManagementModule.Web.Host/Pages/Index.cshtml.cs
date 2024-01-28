using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Appricot.Abp.FileManagementModule.Pages;

public class IndexModel : FileManagementModulePageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}

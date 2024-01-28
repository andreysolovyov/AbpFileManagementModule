using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace Appricot.Abp.FileManagementModule.Samples;

[Area(FileManagementModuleRemoteServiceConsts.ModuleName)]
[RemoteService(Name = FileManagementModuleRemoteServiceConsts.RemoteServiceName)]
[Route("api/FileManagementModule/sample")]
public class SampleController : FileManagementModuleController, ISampleAppService
{
    private readonly ISampleAppService _sampleAppService;

    public SampleController(ISampleAppService sampleAppService)
    {
        _sampleAppService = sampleAppService;
    }

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
    }
}

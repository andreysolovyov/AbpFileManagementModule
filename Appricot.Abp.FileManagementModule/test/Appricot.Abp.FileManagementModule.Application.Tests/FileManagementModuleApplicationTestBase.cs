using Volo.Abp.Modularity;

namespace Appricot.Abp.FileManagementModule;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class FileManagementModuleApplicationTestBase<TStartupModule> : FileManagementModuleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

using Volo.Abp.Modularity;

namespace Appricot.Abp.FileManagementModule;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class FileManagementModuleDomainTestBase<TStartupModule> : FileManagementModuleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

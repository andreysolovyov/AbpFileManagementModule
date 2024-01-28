using Appricot.Abp.FileManagementModule.Samples;
using Xunit;

namespace Appricot.Abp.FileManagementModule.MongoDB.Samples;

[Collection(MongoTestCollection.Name)]
public class SampleRepository_Tests : SampleRepository_Tests<FileManagementModuleMongoDbTestModule>
{
    /* Don't write custom repository tests here, instead write to
     * the base class.
     * One exception can be some specific tests related to MongoDB.
     */
}

using Appricot.Abp.FileManagementModule.Samples;
using Xunit;

namespace Appricot.Abp.FileManagementModule.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<FileManagementModuleMongoDbTestModule>
{

}

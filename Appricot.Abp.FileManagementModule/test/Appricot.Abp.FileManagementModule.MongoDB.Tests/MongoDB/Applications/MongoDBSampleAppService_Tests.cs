using Appricot.Abp.FileManagementModule.MongoDB;
using Appricot.Abp.FileManagementModule.Samples;
using Xunit;

namespace Appricot.Abp.FileManagementModule.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<FileManagementModuleMongoDbTestModule>
{

}

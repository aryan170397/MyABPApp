using MyABPApp.Samples;
using Xunit;

namespace MyABPApp.EntityFrameworkCore.Applications;

[Collection(MyABPAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MyABPAppEntityFrameworkCoreTestModule>
{

}

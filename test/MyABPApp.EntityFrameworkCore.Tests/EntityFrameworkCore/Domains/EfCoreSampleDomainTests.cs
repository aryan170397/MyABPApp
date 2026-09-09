using MyABPApp.Samples;
using Xunit;

namespace MyABPApp.EntityFrameworkCore.Domains;

[Collection(MyABPAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MyABPAppEntityFrameworkCoreTestModule>
{

}

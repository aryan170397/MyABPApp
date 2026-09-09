using Xunit;

namespace MyABPApp.EntityFrameworkCore;

[CollectionDefinition(MyABPAppTestConsts.CollectionDefinitionName)]
public class MyABPAppEntityFrameworkCoreCollection : ICollectionFixture<MyABPAppEntityFrameworkCoreFixture>
{

}

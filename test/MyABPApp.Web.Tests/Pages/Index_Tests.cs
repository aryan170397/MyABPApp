using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MyABPApp.Pages;

[Collection(MyABPAppTestConsts.CollectionDefinitionName)]
public class Index_Tests : MyABPAppWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}

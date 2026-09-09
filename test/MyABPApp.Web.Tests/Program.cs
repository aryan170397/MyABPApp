using Microsoft.AspNetCore.Builder;
using MyABPApp;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("MyABPApp.Web.csproj"); 
await builder.RunAbpModuleAsync<MyABPAppWebTestModule>(applicationName: "MyABPApp.Web");

public partial class Program
{
}

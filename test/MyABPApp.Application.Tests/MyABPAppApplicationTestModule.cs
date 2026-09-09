using Volo.Abp.Modularity;

namespace MyABPApp;

[DependsOn(
    typeof(MyABPAppApplicationModule),
    typeof(MyABPAppDomainTestModule)
)]
public class MyABPAppApplicationTestModule : AbpModule
{

}

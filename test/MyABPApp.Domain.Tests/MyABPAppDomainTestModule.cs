using Volo.Abp.Modularity;

namespace MyABPApp;

[DependsOn(
    typeof(MyABPAppDomainModule),
    typeof(MyABPAppTestBaseModule)
)]
public class MyABPAppDomainTestModule : AbpModule
{

}

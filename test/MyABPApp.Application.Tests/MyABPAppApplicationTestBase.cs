using Volo.Abp.Modularity;

namespace MyABPApp;

public abstract class MyABPAppApplicationTestBase<TStartupModule> : MyABPAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

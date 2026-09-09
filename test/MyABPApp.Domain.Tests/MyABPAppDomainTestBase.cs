using Volo.Abp.Modularity;

namespace MyABPApp;

/* Inherit from this class for your domain layer tests. */
public abstract class MyABPAppDomainTestBase<TStartupModule> : MyABPAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

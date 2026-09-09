using MyABPApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MyABPApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MyABPAppEntityFrameworkCoreModule),
    typeof(MyABPAppApplicationContractsModule)
)]
public class MyABPAppDbMigratorModule : AbpModule
{
}

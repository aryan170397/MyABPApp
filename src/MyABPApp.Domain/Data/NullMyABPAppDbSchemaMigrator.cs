using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MyABPApp.Data;

/* This is used if database provider does't define
 * IMyABPAppDbSchemaMigrator implementation.
 */
public class NullMyABPAppDbSchemaMigrator : IMyABPAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

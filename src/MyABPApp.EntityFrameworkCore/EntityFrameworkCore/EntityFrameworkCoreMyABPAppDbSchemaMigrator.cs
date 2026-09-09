using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyABPApp.Data;
using Volo.Abp.DependencyInjection;

namespace MyABPApp.EntityFrameworkCore;

public class EntityFrameworkCoreMyABPAppDbSchemaMigrator
    : IMyABPAppDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMyABPAppDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the MyABPAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MyABPAppDbContext>()
            .Database
            .MigrateAsync();
    }
}

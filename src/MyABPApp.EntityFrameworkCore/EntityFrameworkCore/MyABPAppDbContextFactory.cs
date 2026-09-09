using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyABPApp.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class MyABPAppDbContextFactory : IDesignTimeDbContextFactory<MyABPAppDbContext>
{
    public MyABPAppDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        MyABPAppEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<MyABPAppDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new MyABPAppDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MyABPApp.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false)
            .AddEnvironmentVariables();

        return builder.Build();
    }
}

using System.Threading.Tasks;

namespace MyABPApp.Data;

public interface IMyABPAppDbSchemaMigrator
{
    Task MigrateAsync();
}

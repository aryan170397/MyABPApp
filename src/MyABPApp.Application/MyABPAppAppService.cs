using MyABPApp.Localization;
using Volo.Abp.Application.Services;

namespace MyABPApp;

/* Inherit your application services from this class.
 */
public abstract class MyABPAppAppService : ApplicationService
{
    protected MyABPAppAppService()
    {
        LocalizationResource = typeof(MyABPAppResource);
    }
}

using MyABPApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyABPApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MyABPAppController : AbpControllerBase
{
    protected MyABPAppController()
    {
        LocalizationResource = typeof(MyABPAppResource);
    }
}

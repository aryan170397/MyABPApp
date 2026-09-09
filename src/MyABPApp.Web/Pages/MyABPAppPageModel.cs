using MyABPApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MyABPApp.Web.Pages;

public abstract class MyABPAppPageModel : AbpPageModel
{
    protected MyABPAppPageModel()
    {
        LocalizationResourceType = typeof(MyABPAppResource);
    }
}

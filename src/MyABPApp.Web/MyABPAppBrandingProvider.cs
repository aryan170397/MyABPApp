using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using MyABPApp.Localization;

namespace MyABPApp.Web;

[Dependency(ReplaceServices = true)]
public class MyABPAppBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<MyABPAppResource> _localizer;

    public MyABPAppBrandingProvider(IStringLocalizer<MyABPAppResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}

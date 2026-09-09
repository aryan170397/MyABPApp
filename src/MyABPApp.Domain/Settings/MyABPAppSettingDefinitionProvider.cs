using Volo.Abp.Settings;

namespace MyABPApp.Settings;

public class MyABPAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MyABPAppSettings.MySetting1));
    }
}

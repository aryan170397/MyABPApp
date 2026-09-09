using MyABPApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyABPApp.Products;

public class ProductPermissionDefinitionProvider
    : PermissionDefinitionProvider
{
    public override void Define(
        IPermissionDefinitionContext context)
    {
        var group = context.AddGroup(
            ProductPermissions.GroupName,
            L("Products"));

        var products = group.AddPermission(
            ProductPermissions.Products.Default,
            L("Products"));

        products.AddChild(
            ProductPermissions.Products.Create,
            L("Create"));

        products.AddChild(
            ProductPermissions.Products.Update,
            L("Update"));

        products.AddChild(
            ProductPermissions.Products.Delete,
            L("Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MyABPAppResource>(name);
    }
}
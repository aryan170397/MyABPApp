namespace MyABPApp.Products;

public static class ProductPermissions
{
    public const string GroupName = "Products";

    public static class Products
    {
        public const string Default = GroupName + ".Products";

        public const string Create = Default + ".Create";

        public const string Update = Default + ".Update";

        public const string Delete = Default + ".Delete";
    }
}
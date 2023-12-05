namespace VertiqTodoSample;

[DependsOn(typeof(VertiqMudBlazorTemplatesModule))]
public sealed record VertiqTodoSampleShellModule : ModuleBase
{
    public override void RegisterNavItems(NavItemCollection navItems) => navItems
        .Add(("Home", "/"))
    ;
}
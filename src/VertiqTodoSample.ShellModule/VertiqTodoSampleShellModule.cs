
namespace VertiqTodoSample;

[DependsOn(typeof(VertiqMudBlazorTemplatesModule))]
[DependsOn(typeof(VertiqFluxorConventionsModule))]
[DependsOn(typeof(VertiqMaterialDesignIconsIconPackModule))]
public sealed record VertiqTodoSampleShellModule : ModuleBase
{
    public override void RegisterNavItems(NavItemCollection navItems) => navItems
        .Add(("Todo", "/", MdiIcons.ListStatus))
    ;

    public override void ConfigureServices(IApplication application, IServiceCollection services)
    {
        services.AddXpoHive(nameof(VertiqTodoSampleShellModule), x => x
            .AddTypes(typeof(Pages.Index.DbTodo))
            .WithAutoCreateOption(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema)
            .InMemory()
        );
    }
}
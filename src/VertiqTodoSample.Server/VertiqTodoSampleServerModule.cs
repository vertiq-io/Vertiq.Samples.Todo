namespace VertiqTodoSample;

[DependsOn(typeof(VertiqTodoSampleShellModule))]
[DependsOn(typeof(VertiqBlazorServerDefaultModule))]
[DependsOn(typeof(VertiqHttpTransportServerModule))]
[DependsOn(typeof(VertiqNewtonsoftJsonSerializationModule))]
[DependsOn(typeof(VertiqXpoSchemaUpdateModule))]
public sealed record VertiqTodoSampleServerModule : ModuleBase
{
    public override void RegisterIcons(IconsCollection icons) => icons
        .RegisterIcon<DiagnosticIcon, VertiqUnknownSvgIcon>()
        ;
}
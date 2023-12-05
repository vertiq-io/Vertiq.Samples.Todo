namespace VertiqTodoSample;

[DependsOn(typeof(VertiqTodoSampleShellModule))]
[DependsOn(typeof(VertiqBlazorServerDefaultModule))]
[DependsOn(typeof(VertiqHttpTransportServerModule))]
[DependsOn(typeof(VertiqNewtonsoftJsonSerializationModule))]
public sealed record VertiqTodoSampleServerModule : ModuleBase
{

}
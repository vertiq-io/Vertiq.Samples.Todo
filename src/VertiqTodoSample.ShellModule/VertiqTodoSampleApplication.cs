namespace VertiqTodoSample;

public sealed record VertiqTodoSampleApplication : ApplicationBase
{
    public VertiqTodoSampleApplication(
        IConfiguration configuration,
        ILogger logger,
        IServiceCollection services,
        string environmentName
    ) : base(configuration, logger, services, environmentName)
    {
        Catalog.AddModule<VertiqTodoSampleShellModule>();
        MainLayoutType = typeof(Vertiq.Shared.MudBlazorMainLayout);
    }
}

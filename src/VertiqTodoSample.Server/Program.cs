var builder = WebApplication.CreateBuilder(args);

var application = VertiqWebApplicationBuilder
    .CreateWithSerilog(
        "todo.vertiq.io.log",
        logger =>
            new VertiqTodoSampleApplication(
                builder.Configuration,
                logger,
                builder.Services,
                builder.Environment.EnvironmentName
            )
    )
    .UseServerContext(builder)
    .UseModule<VertiqTodoSampleServerModule>()
    .BuildApplication();

var app = builder.Build();

application.ConfigurePipeline(app);

app.Run();

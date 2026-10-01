using JobProcessor.Jobs;
using JobProcessor.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<InMemoryJobRepository>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/health", () => new { status = "ok" });
app.MapPost("/jobs", (InMemoryJobRepository repo) =>
{
    var job = new Job();
    repo.AddJob(job);

    return Results.Ok(new { job });
});

app.Run();
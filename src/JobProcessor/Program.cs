using JobProcessor.Jobs;
using JobProcessor.Repositories;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/health", () => new { status = "ok" });
app.MapPost("/jobs", () =>
{
    var job = new Job();
    var repo = new InMemoryJobRepository();
    repo.AddJob(job);

    return Results.Ok(new { job });
});

app.Run();
using Carter;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCarter();
var assembly = typeof(Program).Assembly;
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblies(assembly);
});
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");


// Configure the HTTP Pipeline
app.MapCarter();

app.Run();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCarter(); // This will register carter classes into asp.net DI
builder.Services.AddMediatR(config =>
{
    // We config that mediatr to look at catalog api files
    config.RegisterServicesFromAssembly(typeof(Program).Assembly); 
});

builder.Services.AddMarten(opt =>
{
    opt.Connection(builder.Configuration.GetConnectionString("Database")!);
}).UseLightweightSessions();

var app = builder.Build();

app.MapCarter();

app.Run();

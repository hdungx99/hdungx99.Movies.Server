using hdungx99.Movies.API;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddServices(builder.Configuration);
builder.Services.AddDIServices();

var app = builder.Build();
app.UseBuilder(app.Environment.IsDevelopment());

app.MapControllers();

app.Run();

using hdungx99.Core.Auth.AuthRegister;
using hdungx99.Movies.API;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddServices();

var app = builder.Build();
app.UseBuilder(app.Environment.IsDevelopment());

app.MapControllers();

app.Run();

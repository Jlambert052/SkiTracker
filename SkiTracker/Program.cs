

using Microsoft.EntityFrameworkCore;
using SkiTracker.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connStrKey = "DevDb";


builder.Services.AddControllers();

builder.Services.AddDbContext<SkiTrackerDbContext>(x => {
    x.UseSqlServer(builder.Configuration.GetConnectionString(connStrKey));
});
builder.Services.AddCors();

var app = builder.Build();

app.UseCors(x => {
        x.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
});

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

using var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();

scope.ServiceProvider.GetService<SkiTrackerDbContext>()!.Database.Migrate();

app.Run();

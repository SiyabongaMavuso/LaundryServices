using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// ✅ Add controllers
builder.Services.AddControllers();

// Add services to the container.

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// ✅ Ensure controllers are mapped
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();

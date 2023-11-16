using WebApplication;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;


var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddJsonOptions(jsonOptions => jsonOptions.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Configuration.AddJsonFile(
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory ?? string.Empty, "appsettings.json"), true, true);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAutoMapper(typeof(Program));
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthentication();
app.MapControllers();

app.Run();
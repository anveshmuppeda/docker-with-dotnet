using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
{
        options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Read CORS origin URL from environment variable
var corsOriginUrl = builder.Configuration["CORS_ORIGIN_URL"];

// Update to Environment variables
builder.Services.AddCors(options =>
    {
        // If you want to hardcode the crosOriginUrl
        // builder => builder.WithOrigins("http://165.232.144.187")
        options.AddPolicy("AllowOrigin",
            builder => builder.WithOrigins(corsOriginUrl)
                              .AllowAnyHeader()
                              .AllowAnyMethod());
    });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{   
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("AllowOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

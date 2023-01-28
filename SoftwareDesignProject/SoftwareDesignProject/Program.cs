using Microsoft.EntityFrameworkCore;
using SoftwareDesignProject.Data;
using SoftwareDesignProject.Data.Interfaces;
using SoftwareDesignProject.Data.Services;
using SoftwareDesignProject.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"));
});
builder.Services.AddTransient<StudentService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// lidhja e interface me service
builder.Services.AddScoped<IFakultetiService, FakultetiService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IFileService, FileService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

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

builder.Services.AddCors(opt => {
    opt.AddPolicy("CorsPolicy", policy => {
        policy.AllowAnyMethod().AllowCredentials().AllowAnyHeader().WithOrigins("http://localhost:3000");
    });
});



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// lidhja e interfaces me services
builder.Services.AddScoped<IFakultetiService, FakultetiService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IAplikimiService, AplikimiService>();
builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddScoped<IProfileMatchService, ProfileMatchService>();
builder.Services.AddScoped<IAnkesaService, AnkesaService>();
builder.Services.AddScoped<IDrejtoriService, DrejtoriService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();

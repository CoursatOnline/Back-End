using Microsoft.EntityFrameworkCore;
using EFCore.CheckConstraints;
using CoursatOnline.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<CoursatOnlineDbContext>(n => n
                .UseSqlServer(builder.Configuration.GetConnectionString("CoursatOnlineConn"))
                .UseDiscriminatorCheckConstraints()
                .UseEnumCheckConstraints());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
